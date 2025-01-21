System.Console.WriteLine("Creating a student...");
System.Console.Write("ID: ");
int ID = int.Parse(Console.ReadLine());
System.Console.Write("Name: ");
string Name = Console.ReadLine();
System.Console.Write("Age: ");
int Age = int.Parse(Console.ReadLine());
System.Console.Write("Average: ");
double Average = double.Parse(Console.ReadLine());
Student student = new Student (ID, Name, Age, Average);

student.GetInfo();
System.Console.WriteLine();
student.IsExcellentStudent();

class Student{
    private int ID;
    private string Name;
    private int Age;
    private double Average;

    public Student (int ID, string Name, int Age, double Average){
        this.ID = ID;
        this.Name = Name;
        this.Age = Age;
        this.Average = Average;
    }

    public void GetInfo(){
        System.Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Average Grade: {Average}");
    }
    public void IsExcellentStudent(){
        if (Average>4.0){
            System.Console.WriteLine($"{Name} is an excellent student!");
        }
        else{
            System.Console.WriteLine($"{Name} is not and excellent student.");
        }
    }

}