using System;
class Program {
    static void Main(){
        System.Console.Write("First Name: ");
        string FirstName = Console.ReadLine();
        System.Console.Write("Last Name: ");
        string LastName = Console.ReadLine();
        System.Console.Write("User Name: ");
        string UserName = Console.ReadLine();
        System.Console.Write("Password: ");
        string password = Console.ReadLine();
        User user = new User(FirstName, LastName, UserName, password);

        System.Console.WriteLine();
        System.Console.WriteLine("To log in enter your Username and Password: ");
        System.Console.Write("Username: ");
        string userName = Console.ReadLine();
        System.Console.Write("Password: ");
        string Password = Console.ReadLine();
        user.Login(userName, Password);

    }
}

class User{
    private string FirstName;
    private string LastName;
    private string UserName;
    private string password;

    public User (string FirstName, string LastName, string UserName, string password){
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.UserName = UserName;
        this.password = password;
    }

    public void Login(string userName, string Password){
        if (this.UserName == userName){
            System.Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");
        }
        else{
            System.Console.WriteLine("Login failed!");
        }
    }

}