
using Microsoft.AspNetCore.Mvc;

namespace OnlineShope_5030_practice.Controllers
{
    public class Product : Controller
    {
        public IActionResult Insert() => View();
        public IActionResult InsertConfirm(string name, string title, int count, int price)
        {
            using (Models.DB_OnlineShope_5030 onlineShope = new Models.DB_OnlineShope_5030())
            {
                Models.Products product = new Models.Products()
                {
                    Title = title,
                    Name = name,
                    Count = count,
                    Price = price
                };
                //product.Name = name;  different ??
                onlineShope.Add(product);
                int a = onlineShope.SaveChanges();  // how manage a paramiter ?
                a += 1;
            }
            return RedirectToAction("Insert", "Product");
        }
        public IActionResult ShowListOfProducts()
        {
            using (Models.DB_OnlineShope_5030 onlineShope = new())
            {
                List<Models.Products> products = onlineShope.Products.ToList();
                ViewData["products"] = products;

            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            using (Models.DB_OnlineShope_5030 onlineShope = new Models.DB_OnlineShope_5030())
            {
                var product = onlineShope.Find<Models.Products>(id);
                onlineShope.Remove(product);
                //onlineShope.Remove<Models.Products>(product);   ???
                onlineShope.SaveChanges();
                return RedirectToAction("ShowListOfProducts", "Product");
            }
        }
        public IActionResult Edit(int id)
        {
            using (Models.DB_OnlineShope_5030 onlineShope = new())
            {
                Models.Products product = onlineShope.Find<Models.Products>(id);
                ViewData["product"] = product;
            }
            return View();
        }
        public IActionResult Update(string title, string name, int price, int count, int id)
        {
            using (Models.DB_OnlineShope_5030 onlineShope = new())
            {
                Models.Products product = onlineShope.Find<Models.Products>(id);
                product.Title = title;
                product.Name = name;
                product.Price = price;
                product.Count = count;
                onlineShope.Update(product);
                onlineShope.SaveChanges();
            };
            return RedirectToAction("ShowListOfProducts", "Product");
        }
        public IActionResult DelteMany(List<int> productsIds)
        {
            using (Models.DB_OnlineShope_5030 onlineShope = new())
            {
                List<Models.Products> products = onlineShope.Products.Where(x => productsIds.Contains(x.Id)).ToList();
                onlineShope.RemoveRange(products);
                onlineShope.SaveChanges();
            }
            return RedirectToAction("ShowListOfProducts", "Product");
        }
        public IActionResult InsertNewProductWithImage() => View();
        public IActionResult InsertConfirmProductWithImagea(string title, string name, int count, int price, IFormFile img)
        {
            using (Models.DB_OnlineShope_5030 onlineShope_5030 = new())
            {
                Models.Products product = new()
                {
                    Title = title,
                    Name = name,
                    Count = count,
                    Price = price
                };
                // img! null
                // img format ? (png or jpg)
                // img size
                if (img != null)
                {
                    string ext = System.IO.Path.GetExtension(img.FileName);
                    if (ext.ToLower() == ".jpg" || ext.ToLower() == ".png")
                    {
                        if (img.Length <= 2 * Math.Pow(1024, 2)) // 2M => 1024 byte -> 1K   1024 K -> 2*1024K -> 2M
                        {
                            byte[] b = new byte[img.Length];
                            img.OpenReadStream().Read(b, 0, b.Length);
                            product.Image = b;

                        }
                    }
                }
                onlineShope_5030.Add(product);
                onlineShope_5030.SaveChanges();
            }
            return RedirectToAction("InsertNewProductWithImage", "Product");
        }
        //public IActionResult SearchProducts(string search)
        //{

        //    using (Models.DB_OnlineShope_5030 onlineShope_5030 = new())
        //    {
        //        var commodities = new List<Models.Products>();
        //        if (search != null)
        //        {
        //            commodities = onlineShope_5030.Products.Where(x => x.Title.ToLower().Contains(search.ToLower())).ToList();
        //        }
        //        else
        //        {
        //            commodities = onlineShope_5030.Products.ToList();
        //        }
        //        commodities = (search != null) ? onlineShope_5030.Products.Where(x => x.Title.ToLower().Contains(search.ToLower())).ToList() : onlineShope_5030.Products.ToList();
        //    }
        //}
    }
}
