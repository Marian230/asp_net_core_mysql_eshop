using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Pages.Shop
{
    public class ShopController : UserController
    {
        public string vendorId = "vendorId";
        public string sizeId = "sizeId";
        public string tagId = "tagId";

        public IActionResult Index()
        {

            this.ViewBag.sortingOptions = this.returnSortingOptions();
            this.ViewBag.Vendors = this.context.Vendor.ToList();
            this.ViewBag.Sizes = this.context.Size.ToList();
            this.ViewBag.Products = ReturnListOfProducts();
            this.ViewBag.Tags = this.context.Tag.Where(x => x.is_Product == true).ToList();
            return View();
        }

        // TODO
        public IActionResult CategorySort()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult VendorSort(int id)
        {
            this.HttpContext.Session.SetString(this.vendorId, id.ToString());
            this.HttpContext.Session.SetString("vendorName", "SONY");

            return RedirectToAction("Index");
        }

        public IActionResult SizeSort(int id)
        {
            this.HttpContext.Session.SetString(this.sizeId, id.ToString());

            return RedirectToAction("Index");
        }

        public IActionResult TagSort(int id)
        {
            this.HttpContext.Session.SetString(this.tagId, id.ToString());

            return RedirectToAction("Index");
        }

        private List<string> returnSortingOptions()
        {
            return new List<string>
            {
                "Alphabetically, A-Z",
                "Alphabetically, Z-A",
                "Price, low to high",
                "Price, high to low",
                "Date, new to old",
                "Date, old to new"
            };
        }

        // NOTHING TESTED HERE
        private List<Product> ReturnListOfProducts()
        {
            List<Product> returnProducts = this.context.Product.ToList();

            if (this.HttpContext.Session.GetString(this.vendorId) != null)
            {
                int vendorId = Convert.ToInt32(this.HttpContext.Session.GetString(this.vendorId));
                returnProducts = returnProducts.Where(x => x.id_Vendor == vendorId).ToList();
            }
            if (this.HttpContext.Session.GetString(this.sizeId) != null)
            {
                int sizeId = Convert.ToInt32(this.HttpContext.Session.GetString(this.sizeId));

                List<Product_Size> product_size_ = this.context.Product_Size.ToList();
                List<Size> size_ = this.context.Size.ToList();

                returnProducts = (from products in returnProducts
                                  from product_size in product_size_
                                  from size in size_
                                  where product_size.id_Size == size.id
                                  where size.id == sizeId
                                  where products.id == product_size.id_Product
                                  select products).ToList();

            }
            if (this.HttpContext.Session.GetString(this.tagId) != null)
            {
                int tagId = Convert.ToInt32(this.HttpContext.Session.GetString(this.tagId));

                List<Product_Tag> product_tag_ = this.context.Product_Tag.ToList();
                List<Tag> tag_ = this.context.Tag.ToList();

                returnProducts = (from product in returnProducts
                                  from product_tag in product_tag_
                                  from tag in tag_
                                  where product.id == product_tag.id_Product
                                  where tag.id == product_tag.id_Tag
                                  where tag.id == tagId
                                  select product).ToList();
            }

            return returnProducts;
        }
    }
}
