using Microsoft.AspNetCore.Mvc;

namespace OnlineShope_5030.Controllers
{
    public class Product : Controller
    {
        public IActionResult Insert() => View();
        public IActionResult InsertConfirm(string name, string title, int count, int price)
        {
            using (Models.Db_OnlineShope_5030 onlineShope = new Models.Db_OnlineShope_5030())
            {
                Models.Products products = new Models.Products()
                {
                    Title = title,
                    Name = name,
                    Count = count,
                    Price = price
                };
                onlineShope.Add(products);
                onlineShope.SaveChanges();
            }
            return RedirectToAction("Insert" , "ProductController");
        }
    }
}
