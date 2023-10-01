using IoC.Console;

// Gelişmeye açık oldu ama değişime kapalı open-closed principle
//BusinessLogic businessLogic = new BusinessLogic(new DataAccessLayer());
BusinessLogic businessLogic = new BusinessLogic(new OracleDAL());
businessLogic.GetProducts().ForEach(p =>
{
    Console.WriteLine($"{p.Id} -- {p.Name} -- {p.Stock} -- {p.Price}");
}); 