
using NestedObjects;

Advisor compSciAdvisor = new ()
{
	Email = "Johnsmith@cptc.edu",
	FullName = "John Smith",
	OfficeLocation = "B17 Rm150"
};

Student stu1 = new()
{
	FirstName = "Homer",
	LastName = "Simpson",
	DateOfBirth = new DateOnly(2000, 3, 30),
	AssignedAdvisor = compSciAdvisor,
	PhoneNumber = "12345678",
	SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");