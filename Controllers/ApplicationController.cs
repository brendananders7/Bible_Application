using Bible_Application.Models;
using Bible_Application.Services;
using NLog;
using Unity.Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Bible_Application.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Home()
        {
            return View("HomeView");
        }

        // GET: Entry Page
        public ActionResult BibleVerseEntry()
        {
            return View("VerseEntryView");
        }

        // GET: Search Page
        public ActionResult BibleVerseSearch()
        {
            return View("VerseSearchView");
        }

        //GET: Submit Search function to return values
        [HttpPost]
        public ActionResult SubmitSearch(BibleDisplayObject displayObject)
        {
            //Dependency Injection for Logger
            UnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, Logger>();
            var logger = container.Resolve<ILogger>();

            logger = LogManager.GetLogger("bibleAppLoggerRules");

            logger.Info("Entered SubmitSearch in Controller");

            try
            {
                searchService search = new searchService();
                displayObject = search.search(displayObject);

                logger.Info("Successfully exiting SubmitSearch in Controller");
                return View("VerseSearchView", displayObject);
            }
            catch (Exception e)
            {

                logger.Error("Exception: " + e.Message);
                return Content(e.Message);
            }
        }

        //GET: Submit Entry to Database
        [HttpPost]
        public ActionResult SubmitEntry(BibleDisplayObject displayObject)
        {
            //Dependency Injection for Logger
            UnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, Logger>();
            var logger = container.Resolve<ILogger>();

            logger = LogManager.GetLogger("bibleAppLoggerRules");

            logger.Info("Entered SubmitEntry in Controller");

            try
            {
                entryService entry = new entryService();
                displayObject = entry.entry(displayObject);

                logger.Info("Successfully exiting SubmitEntry in Controller");

                return View("VerseEntryView", displayObject);
            }
            catch (Exception e)
            {
                logger.Error("Exception: " + e.Message);
                return Content(e.Message);
            }
        }
    }
}