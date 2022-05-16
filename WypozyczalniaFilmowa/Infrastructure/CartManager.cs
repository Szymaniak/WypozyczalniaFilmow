using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WypozyczalniaFilmowa.DAL;
using WypozyczalniaFilmowa.Helpers;
using WypozyczalniaFilmowa.Models;

namespace WypozyczalniaFilmowa.Infrastructure
{
    public class CartManager
    {
        public static int RemoveFromCart(ISession session, int id)
        {
            var cart = GetItem(session);

            var thisFilm = cart.Find(i => i.Film.Id == id);

            int ilosc = 0;
            if(thisFilm == null)
            {
                return ilosc;
            }
            if(thisFilm.Ilosc> 1)
            {
                thisFilm.Ilosc--;
                ilosc = thisFilm.Ilosc;
            }
            else
            {
                cart.Remove(thisFilm);
            }

            session.SetObjectAsJson(Consts.CartSessionKey, cart);

            return ilosc;
        }

        public static decimal GetCartValue(ISession session)
        {
            var items = GetItem(session);
            return items.Sum(i => i.Ilosc * i.Wartosc);
        }
        public static int GetCartQuantity(ISession session)
        {
            var cart = GetItem(session);

            return cart.Sum(i => i.Ilosc);
        }

        public static List<CartItem> GetItem(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(
                session, Consts.CartSessionKey);

            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            return cart;

        }
        public static void AddToCart(ISession session, FilmyContext db, int filmId)
        {
            var cart = GetItem(session);
            var thisFilm = cart.Find(f => f.Film.Id == filmId);
            
            if(thisFilm !=null)
            {
                thisFilm.Ilosc++;
            }
            else
            {
                var newCartItem = db.Filmy.Where(f => f.Id == filmId).SingleOrDefault();

                if(newCartItem != null)
                {
                    var cartItem = new CartItem
                    {
                        Film = newCartItem,
                        Ilosc = 1,
                        Wartosc = newCartItem.Cena

                    };

                    cart.Add(cartItem);

                }
            }

            SessionHelper.SetObjectAsJson(session, Consts.CartSessionKey, cart);
        }
    }
}
