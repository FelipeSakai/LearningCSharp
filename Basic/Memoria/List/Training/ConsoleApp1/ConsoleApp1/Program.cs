using ConsoleApp1;

Console.WriteLine("Enter the number of students in the class: ");
int n = int.Parse(Console.ReadLine());

List<Student> list = new List<Student>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Student #" +i + ":");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Grade: ");
    int grade = int.Parse(Console.ReadLine());
    list.Add(new Student(id,name,grade));
    Console.WriteLine();
}

Console.WriteLine("Enter the id who made the best homework: ");
int searchId= int.Parse(Console.ReadLine());

Student std = list.Find(x => x.Id == searchId);

if (std != null)
{
    Console.WriteLine("Enter the grade of the homework: ");
    int work = int.Parse(Console.ReadLine());
    std.SchoolWork(work);
}
else
{
    Console.WriteLine("This Id is wrong!");
}

Console.WriteLine();
Console.WriteLine("Update the grade of the students");
foreach (Student obj in list)
{
    Console.WriteLine(obj);
}
