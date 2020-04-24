using Bible_Application.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bible_Application.Services
{
    public class entryService
    {
        public BibleDisplayObject entry(BibleDisplayObject displayObject)
        {
            BibleDataObject dataObject = new BibleDataObject();
            convertToData(displayObject, dataObject);

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bible Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string query = "select * from dbo.t_asv where b = @book and c = @chapter and v = @verse";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@book", System.Data.SqlDbType.Int).Value = dataObject.BookSelection;
                command.Parameters.Add("@chapter", System.Data.SqlDbType.Int).Value = dataObject.ChapterNumber;
                command.Parameters.Add("@verse", System.Data.SqlDbType.Int).Value = dataObject.VerseNumber;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataObject.VerseText = reader.GetString(4);
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            displayObject.VerseText = dataObject.VerseText != null ? dataObject.VerseText : "An error has occurred. The database could not find your entry.";

            return displayObject;

        }

        public void convertToData(BibleDisplayObject displayObject, BibleDataObject dataObject)
        {
            BooksInBible books = new BooksInBible();
            foreach (Book b in books.booksOfBible)
            {
                if (b.Name == displayObject.Book)
                {
                    dataObject.BookSelection = b.referenceNum;
                }
            }
            dataObject.ChapterNumber = displayObject.Chapter;
            dataObject.VerseNumber = displayObject.Verse;
        }
    }
}