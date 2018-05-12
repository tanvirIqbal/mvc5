using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // 
        // GET: /HelloWorld/Welcome/?name=Scott&numtimes=4
        //The ? (question mark) in the above URL is a separator, and the query strings follow. The & character separates query strings.
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        // 
        // GET: /HelloWorld/Welcome/1?name=Scott  
        //This time the third URL segment matched the route parameter ID. The Welcome action method contains a parameter (ID) that matched the URL specification in the RegisterRoutes method.
        // In ASP.NET MVC applications, it's more typical to pass in parameters as route data (like we did with ID above) than passing them as query strings.
        // GET: /HelloWorld/Welcome/Scott/
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}