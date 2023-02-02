using Ef_3.Dal;

using var context = new AppDbContext();
foreach (var p in context.Products)
{
    Console.WriteLine(p.Name);
}