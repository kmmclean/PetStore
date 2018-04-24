using System.Threading.Tasks;
using PetStore.Web.Models.Entities;

namespace PetStore.Web.Interfaces
{
    public interface IOrderService
    {
        Task<Order> SaveOrderAsync(Order order);
        Task<Order> GetOrderAsync(long id);
    }
}