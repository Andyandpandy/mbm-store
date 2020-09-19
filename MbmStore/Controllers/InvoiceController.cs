using System.Web.Mvc;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class InvoiceController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.Invoices = Repository.Invoices;
            return View();
        }
    }
}