using BlazorServerSide.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerSide.Models;

namespace BlazorServerSide.Data
{
    public class PurchaseOrderService
    {
        public ApplicationDbContext _context { get; }
        public PurchaseOrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PurchaseOrder>> GetPurchaseOrdersAsync()
        {
            return await _context.PurchaseOrders.ToListAsync();
        }
    }
}
