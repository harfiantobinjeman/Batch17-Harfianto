using static System.Console;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DayOop.PartOne;

//setiap creat ojbeck instan gunakan operator baru
//Employee emp1 = new Employee();
/*
 * //yg public punya
 * emp1 = new Employee();
 * emp1.firsName = "codeId";
 * emp1.empId = 1001;
*/

/*//gunakan encapsulation untuk manipulasi
//create objec employee with parameter construktor
Employee emp2 = new Employee(100,"harfi","anto",new DateTime(),5_000_000,"bandung");

emp2.Role = "QA";
emp2.BasicSalary = 6_000_000;

*//*emp1.FirsName = "Dian";
emp1.LastName = "Anto";
emp1.City = "Bandung";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 5_000_000;
emp1.EmpId = 1002;
emp1.Role = "sales";*//*

Employee emp4 =new Employee(1004,"yuli","aja", new DateTime(), 3_500_000, "kalimantan", "progamer");
Employee emp3 = new Employee(1004, "yuli1", "aja2", new DateTime(), 3_000_000, "kalimantan1", "progamer2");
Employee emp1 = new Employee(1004, "yuli1", "aja2", new DateTime(), 3_000_000, "kalimantan1", "progamer2");

*//*WriteLine(emp1.ToString());*//*
WriteLine(emp2.ToString());
WriteLine(emp4.ToString());
WriteLine($"Total Employe : {Employee.totalEmployee}");
WriteLine($"Total Basik Salary  : {Employee.totalBasicSalary}");
List<Employee> listEmp = new List<Employee>() { emp3, emp1, emp2, emp4 };
foreach (var item in listEmp)
{
    Console.WriteLine(item.ToString()); //to string nampilkan semua data
}*/

WriteLine("===========================List==============================");
Progremer prog1 = new Progremer(1010, "hisyam", "madu", new DateTime(2022, 05, 23), 5_000_000, "bandung", 500_000);
List<Employee> listEmp1 = new List<Employee>() {prog1 };

foreach (var item in listEmp1)
{
    Console.WriteLine(item.ToString()); //to string nampilkan semua data
}


Sales sales1 = new Sales(1009, "hisyam", "madu", new DateTime(2022, 05, 23), 5_000_000, "bandung", 500_000);
List<Employee> listEmp2 = new List<Employee>() {sales1 };
foreach (var item in listEmp2)
{
    Console.WriteLine(item.ToString()); //to string nampilkan semua data
}

Qa qa = new Qa(1009, "hisyam", "madu", new DateTime(2022, 05, 23), 5_000_000, "bandung", 500_000);
List<Employee> listEmp3 = new List<Employee>() { qa };
foreach (var item in listEmp3)
{
    Console.WriteLine(item.ToString()); //to string nampilkan semua data
}