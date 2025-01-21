System.Console.Write("Order number: ");
int OrderNumber = int.Parse(Console.ReadLine());
System.Console.Write("Product name: ");
string ProductName = Console.ReadLine();
System.Console.Write("Quantity: ");
int Quantity = int.Parse(Console.ReadLine());
System.Console.Write("Total amount: ");
decimal TotalAmount = decimal.Parse(Console.ReadLine());
Order order = new Order(OrderNumber, ProductName, Quantity, TotalAmount);
Order order1 = new Order("Phone", 12);
Order order2 = new Order("Toy Car", 120.0m);

order.DisplayInfo();
order1.DisplayInfo();
order2.DisplayInfo();

class Order{
    private int OrderNumber;
    private string ProductName;
    private int Quantity;
    private decimal TotalAmount;

    public Order(int OrderNumber, string ProductName, int Quantity, decimal TotalAmount){
        this.OrderNumber = OrderNumber;
        this.ProductName = ProductName;
        this.Quantity = Quantity;
        this.TotalAmount = TotalAmount;
    }
    public Order(string ProductName, int Quantity){
        this.ProductName = ProductName;
        this.Quantity = Quantity;
    }
    public Order(string ProductName, decimal TotalAmount){
        this.ProductName = ProductName;
        this.TotalAmount = TotalAmount;
    }

    public void DisplayInfo(){
        System.Console.WriteLine();
        System.Console.WriteLine("Order has been recorder!");
        System.Console.WriteLine($"Order number: {OrderNumber}");
        System.Console.WriteLine($"Name of product: {ProductName}");
        System.Console.WriteLine($"Quantity: {Quantity}");
        System.Console.WriteLine($"Total amount: {TotalAmount}");
    }

}