using PierresBakery.Models;
using Microsoft.AspNetCore.Mvc;

namespace PierresBakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      
      return View();
    }

    [Route("/checkout")]
    public ActionResult Checkout(int pastryQuantity, int breadQuantity)
    {
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Bread breadOrder = new Bread(breadQuantity);
      pastryOrder.PastryQuantity = pastryQuantity;
      breadOrder.BreadQuantity = breadQuantity;
      double pastryTotalCost = pastryOrder.PastryCost();
      double breadTotalCost = breadOrder.BreadCost();

      

      return View();
     

      
    }
  }


}