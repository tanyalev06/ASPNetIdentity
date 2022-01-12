using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private List<ListDemo> _listDemo;

        public HomeController()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
                 new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
            };
        }
        public ActionResult Index()
        {
            ViewData["Lst"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            ViewData["Text"] = "Наш сайт";
            return View();
        }


        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }
    }
}
