using System;
class Program {
    static void Main(){
        while (true){
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Operation: ");
            char op = char.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            
            Calculator calc = new Calculator(num1, num2);

            double result;
            switch (op) {
                case '+':
                    result = calc.Sum();
                    break;
                case '-':
                    result = calc.Subtract();
                    break;
                case '*':
                    result = calc.Multiply();
                    break;
                case '/':
                    if (num2 != 0) {
                        result = calc.Division();
                    } 
                    else {
                        Console.WriteLine("Error: Division by zero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Not defined.");
                    continue;
            }
            Console.WriteLine($"{num1} {op} {num2} = " + result);
            System.Console.WriteLine();
        }
    }
}

class Calculator{
    private int num1;
    private int num2;

    public Calculator(int num1, int num2){
        this.num1 = num1;
        this.num2 = num2;
    }
    public double Sum(){
        return num1 + num2;
    }
    public double Subtract(){
        return num1 - num2;
    }
    public double Multiply(){
        return num1 * num2;
    }
    public double Division(){
        return num1 / num2;
    }
}
