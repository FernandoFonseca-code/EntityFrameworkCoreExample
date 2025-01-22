using EntityFrameworkCoreExample;

//
using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "John Doe",
    DateOfBirth = new(1990, 1, 1),
    EmailAddress = "john.doe@example.com"
};

Student s2 = new()
{
    FullName = "Jane Doe",
    DateOfBirth = new(1991, 1, 1),
    EmailAddress = "jane.doe@example.com"
};

dbContext.Students.Add(s); // prepares the Student INSERT statement
dbContext.SaveChanges(); // executes pending INSERT statement

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from Db (SELECT *
//                            FROM Students)
List<Student> allstudents = dbContext.Students.ToList(); // Method syntax

foreach (Student stu in allstudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}
