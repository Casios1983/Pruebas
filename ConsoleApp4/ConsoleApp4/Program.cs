// See https://aka.ms/new-console-template for more information
using ConsoleApp4.Models;

var db = new NorthwindContext();

var listado = db.Products.OrderByDescending(x => x.UnitsInStock)
                       .Where(x => x.SupplierId == 12).ToList();
calular(126, listado);

void calular(short? embargo, List<Product> listar)
{
 
        short? total = 0;

    foreach (var item in listar)
    {
      total = (short?)(item.UnitsInStock - embargo); 
    }
    
}