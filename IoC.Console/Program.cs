using IoC.Console;

BusinessLogic businessLogic = new BusinessLogic();
businessLogic.GetProducts().ForEach(p =>
{
    Console.WriteLine($"{p.Id} -- {p.Name} -- {p.Stock} -- {p.Price}");
}); 