using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

using System.Net.Http.Formatting;

namespace TwitterClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Tweets model = null;
            var client = new HttpClient();
            var task = client.GetAsync("http://search.twitter.com/search.json?q=plurarsight")
                .ContinueWith((taskwithresponce) =>
            {
                var responce = taskwithresponce.Result;
                var readtask = responce.Content.ReadAsAsync<Tweets>();
                readtask.Wait();
                model = readtask.Result;
            }
            );
            task.Wait();
            return View(model.results);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}