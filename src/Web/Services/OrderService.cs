using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PetStore.Web.Data;
using PetStore.Web.Interfaces;
using PetStore.Web.Models.Entities;

namespace PetStore.Web.Services
{
    public class OrderService : IOrderService
    {
        private readonly PetStoreContext _context;
        private readonly HttpClient _client;

        public OrderService(PetStoreContext context, HttpClient client)
        {
            _context = context;
            _client = client;
        }

        public async Task<Order> GetOrderAsync(long id)
        {
            var order = await _context.Orders.FindAsync(id);

            return order;
        }

        public async Task<Order> SaveOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return order;
        }
    }
}