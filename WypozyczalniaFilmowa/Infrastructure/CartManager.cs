using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        private static List<CartItem> GetItem(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(
                session, Consts.CartSessionKey);

            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            return cart;

        }
    }
}
