using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WypozyczalniaFilmowa.DAL;
using WypozyczalniaFilmowa.Helpers;
using WypozyczalniaFilmowa.Infrastructure;
using WypozyczalniaFilmowa.Models;

namespace WypozyczalniaFilmowa.Controllers
{
    public class KoszykController : Controller
    {
        FilmyContext db;

        public KoszykController(FilmyContext db)
        {
            this.db = db;
        }
        
        [Route("Koszyk")]
        public IActionResult Index()
        {

            var cart = CartManager.GetItem(HttpContext.Session);
            ViewBag.cart = cart;
            ViewBag.total = CartManager.GetCartValue(HttpContext.Session);
            return View();
        }

        public IActionResult Kup(int id)
        {
            CartManager.AddToCart(HttpContext.Session, db, id);
            //var film = db.Filmy.Find(id);
            //if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey) == null)
            //{
            //    List<CartItem> cart = new List<CartItem>();
            //    cart.Add(new CartItem { Film = film, Ilosc = 1, Wartosc = film.Cena });
            //    SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.CartSessionKey, cart);

            //}
            //else
            //{
            //    List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);
            //    int index = InCart(id);
            //    if(index != -1)
            //    {
            //        cart[index].Ilosc++;
            //    }
            //    else
            //    {
            //        cart.Add(new CartItem { Film = film, Ilosc = 1, Wartosc = film.Cena });

            //    }
            //    SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.CartSessionKey, cart);

            //}
            return RedirectToAction("Index");
        }
        public IActionResult Usun(int id)
        {
            ////List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "koszyk");
            ////int index = InCart(id);
            ////cart.RemoveAt(index);
            ////SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.CartSessionKey, cart);
            ////return RedirectToAction("Index");

            var model = new UsuwanieViewModel()
            {
                ItemId = id,
                ItemQuantity = CartManager.RemoveFromCart(
                    HttpContext.Session, id),
                CartValue = CartManager.GetCartValue(
                    HttpContext.Session),
                CartQuantityTotal = CartManager.GetCartQuantity(HttpContext.Session)
            };

            return Json(model);
        }
        private int InCart(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);
            for(int i  = 0; i < cart.Count(); i++)
            {
                if (cart[i].Film.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
