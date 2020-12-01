using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rybcansky_Shop.Controllers.ModelController.Product;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers
{
    public class ProductsController : SecuredTemplateController<Product>
    {
        public override IActionResult Detail(int id)
        {
            this.CategoryNameQuery(id);
            this.VendorNameQuery(id);
            this.VariantQuery(id);

            return base.Detail(id);
        }

        public override IActionResult Edit(int id)
        {
            this.ViewBag.CategoryQuery = this.context.Category.ToList();
            this.ViewBag.VendorQuery = this.context.Vendor.ToList();

            /*this.ViewBag.CategoryQuery = this.GetCategorySelectListItem(this.context.Category.ToList());
            this.ViewBag.VendorQuery = this.GetVendorSelectListItem(this.context.Vendor.ToList());*/

            this.context.Product.Find(id).Categories = this.GetCategories();

            return base.Edit(id);
        }

        private IEnumerable<SelectListItem> GetCategories()
        {
            var list = new SelectListItem[this.context.Category.Count()];
            List<Category> categories = this.context.Category.ToList();

            for (int i = 0; i < list.Count(); i++)
                list[i] = new SelectListItem() { Text = categories[i].name, Value = categories[i].id.ToString() };

            return list;
        }

        private IEnumerable<SelectListItem> GetCategorySelectListItem(List<Category> data)
        {
            var returnList = new SelectListItem[data.Count()];

            for (int i = 0; i < data.Count(); i++)
                returnList[i] = new SelectListItem() { Text = data[i].name, Value = data[i].id.ToString() };

            return returnList;
        }

        private IEnumerable<SelectListItem> GetVendorSelectListItem(List<Vendor> data)
        {
            var returnList = new SelectListItem[data.Count()];

            for (int i = 0; i < data.Count(); i++)
                returnList[i] = new SelectListItem() { Text = data[i].name, Value = data[i].id.ToString() };

            return returnList;
        }

        private void CategoryNameQuery(int id)
        {
            this.ViewBag.CategoryQuery = (from product in this.context.Product
                                          from category in this.context.Category
                                          where product.id == id
                                          where product.id_Category == category.id
                                          select new { category.name }).ToList()[0].name;
        }

        private void VendorNameQuery(int id)
        {
            this.ViewBag.VendorQuery = (from product in this.context.Product
                                        from vendor in this.context.Vendor
                                        where product.id == id
                                        where product.id_Vendor == vendor.id
                                        select new { vendor.name }).ToList()[0].name;
        }

        private void VariantQuery(int id)
        {
            this.ViewBag.VariantQuery = (from product in this.context.Product
                                         from variant in this.context.Variant
                                         where product.id == id
                                         where variant.id_Product == product.id
                                         select new VariantClass() { color = variant.color, price_Discount = variant.price_Discount, price_Standart = variant.price_Standart, stock_Number = variant.stock_Number }).ToList();
        }

        private void CategoryQuery(int id)
        {
            this.ViewBag.CategoryQuery = (from product in this.context.Product
                                          from category in this.context.Category
                                          where product.id == id
                                          where product.id_Category == category.id
                                          select new Category() { id = category.id, description = category.description, name = category.name }).ToList();
        }

        private void VendorQuery(int id)
        {
            this.ViewBag.VendorQuery = (from product in this.context.Product
                                        from vendor in this.context.Vendor
                                        where product.id == id
                                        where product.id_Vendor == vendor.id
                                        select new Vendor() { id = vendor.id, name = vendor.name }).ToList();
        }
    }
}