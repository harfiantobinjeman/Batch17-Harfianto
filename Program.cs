// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Day03;
//MyCollection.InitHasil();

//MyCollection.InitDictionary();

var list = new List<string> { "Asep","Budi","Ujanf"};
var student = MyCollection.GetStudent(ref list);

foreach (var item in student)
{
    Console.WriteLine(item);
}

