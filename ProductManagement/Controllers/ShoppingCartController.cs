using DataLayer;
using DataLayer.Services;
using DomainModels.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Controllers
{
    public class ShoppingCartController : Controller
    {
        //ProdDbContext db;
        //private readonly IProductData productData;
        //private readonly ShoppingCartService shoppingCartService;
        //public ShoppingCartController(ProdDbContext _db, IProductData _productData,ShoppingCartService _shoppingCartService)
        //{
        //    db = _db;
        //    productData = _productData;
        //    shoppingCartService = _shoppingCartService;
        //}
        //public ActionResult AddtoCart(int id, ShoppingCart shoppingCart)
        //{
        //    var auid = shoppingCartService.GetCart();
        //    var cartItems = db.ShoppingCarts.ToList().Where(e => e.ApplicationUserId == auId && e.MenuItemId == a).FirstOrDefault();
        //    if (cartItems == null)
        //    {
        //        db.ShoppingCarts.Add(shoppingCart);
        //        db.SaveChanges();
        //    }
        //    else
        //    {
        //        cartItems.Count = cartItems.Count + 1;
        //        db.SaveChanges();
        //    }
        //    GlobalVariable.CartCount = GlobalVariable.CartCount + 1;
        //    return RedirectToAction("Cart");
        //}

        //public ActionResult Cart()
        //{

        //    ViewBag.uId = User.Identity.GetUserId();
        //    string auId = ViewBag.uId;
        //    var cartItem = db.ShoppingCarts.Where(e => e.ApplicationUserId == auId).ToList();
        //    return View(cartItem);

        //}
        //[Authorize]
        //public ActionResult Details(int id)
        //{
        //    ViewBag.user = User.Identity.GetUserId();
        //    var info = db.MenuItems.Where(e => e.Id == id).FirstOrDefault();
        //    return View(info);
        //}
    }
}
