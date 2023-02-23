using ef_dbfirst_tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_dbfirst_tutorial
{
    internal class OrdersController
    {
        private readonly SalesDbContext _context;

        public OrdersController()
        {
            _context = new SalesDbContext();
        }

        public async Task<List<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }
        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }
        public async Task<bool> InsertAsync(Order order)
        {
            _context.Orders.Add(order);
            var changes = await _context.SaveChangesAsync();
            return (changes == 1) ? true : false; 
        }
        public async Task<bool> UpdateAsync(Order order)
        {
            var ord = await GetByIdAsync(order.Id);
            if(ord is null)
            {
                throw new Exception("Not found~!");
            }
            _context.Orders.Entry(ord).State = EntityState.Modified;
            var changes = await _context.SaveChangesAsync();
            return(changes == 1) ? true : false;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var ord = await GetByIdAsync(id);
            if (ord is null)
            {
                throw new Exception("Not found~!");
            }
            _context.Orders.Remove(ord);
            var changes = await _context.SaveChangesAsync();
            return (changes==1) ? true : false;
        }
    }
}
