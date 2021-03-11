using DomainModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Services
{
    public class ShoppingCartService
    {
        private readonly ProdDbContext _prodDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCart> shoppingCartItems { get; set; }
        public ShoppingCartService(ProdDbContext prodDbContext)
        {
            _prodDbContext = prodDbContext;
        }
        public ShoppingCartService GetCart(IServiceProvider services)
        {
            //The IServiceProvider parameter of GetCart method is going to give access
            //to the services collection 
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ProdDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCartService(context) { ShoppingCartId = cartId };
        }
    }
}
