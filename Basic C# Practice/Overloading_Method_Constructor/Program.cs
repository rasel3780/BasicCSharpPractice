using Overloading_Method_Constructor;



Student student1 = new Student("st-01", "Rasel");
Student student2 = new Student("st-02", "Kibira", "kibria.example@gmail.com");
Student student3 = new Student();

student1.ShowInfo(student1.Id);
student1.ShowInfo(true);

student2.ShowInfo(student2.Id);
student2.ShowInfo(true);

student3.ShowInfo(true);

