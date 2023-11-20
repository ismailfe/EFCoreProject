
using EFCore.DatabaseFirst.Scaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var _context = new DbEfcoreDbFirstContext())
{
    var products = await _context.Products.ToListAsync();


    foreach (var product in products)
    {
        Console.WriteLine(product.Id + ":" + product.Name + " : " + product.Price);
    }

}

