using Inheritance_Example1;

Course course1 = new Course();
course1.Title = "OOP using C#";
course1.Fee = 20000;

Course course2 = new Course();
course2.Title = "Advanced Data Science using Python";
course2.Fee = 15000;

Course course3 = new Course();
course3.Title = "Networking Basics";
course3.Fee = 10000;

Course course4 = new Course();
course4.Title = "Java for Professionals";
course4.Fee = 20000;


RegularParticipant regularParticipant = new RegularParticipant();
regularParticipant.Name = "Rasel Kibra";
regularParticipant.PersonalContact = "019";
regularParticipant.AlternativeContacNo = "015";
regularParticipant.Enroll(course1);
Console.WriteLine(regularParticipant.GetTotalPayable());
regularParticipant.Enroll(course2);
Console.WriteLine(regularParticipant.GetTotalPayable());

ProfessonalParticipant professonalParticipant = new ProfessonalParticipant();
professonalParticipant.Name = "Kibria";
professonalParticipant.PersonalContact = "018";
professonalParticipant.CompanyContactNumber = "1";
professonalParticipant.CompanyName = "C#";
professonalParticipant.Enroll(course3);
Console.WriteLine(professonalParticipant.GetTotalPayable());
professonalParticipant.Enroll(course4);
Console.WriteLine(professonalParticipant.GetTotalPayable());