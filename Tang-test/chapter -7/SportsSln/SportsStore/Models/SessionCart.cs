using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportsStore.Infrastructure;

namespace SportsStore.Models
{
    public class SessionCart : Cart
    {
        // This class has only one property
        // Within its instance, there is only one fields to store the state
        [JsonIgnore] 
        public ISession Session { get; set; }

        // Get "Cart" from Session
        // Why we use static method here ???
        public static Cart GetCart(IServiceProvider services)
        {
            //ISession session = HttpContext.Session;  // cannot get Session from static method by this way
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            SessionCart sessionCart = session.GetJson<SessionCart>("Cart") ?? new SessionCart();
            sessionCart.Session = session;
            return sessionCart;
        }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.SetJson("Cart",this);
        }

        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session.SetJson("Cart",this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}