using static System.Console;
using Day06;
Person yuli = new Costumers("Yuli","kartiwan", "yuli@gmail.com", new DateTime(1998,4,24),"aku1234");
Costumers dios = new Costumers("Dios", "iawan", "iwaan@gmail.com", new DateTime(1998, 12, 12), "asdaf");
Costumers rian = new Costumers("rian", "heru", "her@gmail.com", new DateTime(1998, 2, 4), "tytt");

var lisOfCostumer = new List<Person>() { yuli, dios, rian };


var incomeYuli = new Dictionary<string, decimal>
{
    {"kontrakan",10_000_000 },
    {"Toko",20_000_000 }
};
//yuli.TotalIncam(incomeYuli);
yuli.TotalRevenue = yuli.TotalIncam(incomeYuli);

var incomeDios = new Dictionary<string, decimal>
{
    {"kos-kosan",20_000_000 },
    {"Jual-online",600_000 }
};
dios.TotalRevenue = dios.TotalIncam(incomeDios);
var incomeRian = new Dictionary<string, decimal>
{
    {"super market",50_000_000 },
    {"travel",900_000 }
};
rian.TotalRevenue = rian.TotalIncam(incomeRian);

foreach (var item in lisOfCostumer)
{
    Console.WriteLine(item);
}
Console.WriteLine("==========lol===========");
var listHighest = lisOfCostumer.Where(c => c.TotalRevenue <= 30_000_000).ToList();

foreach (var item in listHighest)
{
    WriteLine($"FullName : {item.FirsName} {item.LastName} Email : {item.Email} Ulang Tahun : {item.Birthday} Total Reveneue : {item.TotalRevenue}");
}

var query = lisOfCostumer.Select(cust =>
new
{
    Fullname = cust.FirsName + " " + cust.LastName,
    Email = cust.Email,
    TotalRevenue = cust.TotalRevenue
}
);
foreach (var item in query)
{
    WriteLine(item);
}

//LinQ.IntroLinq();

