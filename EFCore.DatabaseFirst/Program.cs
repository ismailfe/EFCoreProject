using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbConextInitializer.Build();
using (var _context = new AppDbContext(DbConextInitializer.OptionsBuilder.Options))
{
    var products = await _context.Products.ToListAsync();


foreach (var product in products)
    {
        Console.WriteLine(product.Id + ":" + product.Name + " : " + product.Price);
    }




}



