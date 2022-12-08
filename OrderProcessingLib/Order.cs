namespace OrderProcessingLib;
public class Order
{
    public int OrderId{get;set;}
    public DateTime OrderDate{get;set;}
    public int CustomerID {get;set;}
    public double TotalAmount {get;set;}
    public string Status{get;set;}


    public Order()
    {
        OrderId = 0;
        OrderDate =new DateTime(2000,10,01);
        CustomerID = 0;
        TotalAmount = 0.00;
        Status = " ";
    }
    public Order(int orderId, DateTime orderDate, int customerID, double totalAmount, string status)
    {
        OrderId = orderId;
        OrderDate =  orderDate;
        CustomerID = customerID;
        TotalAmount = totalAmount;
        Status = status;

    }

    public void Display(){
    Console.WriteLine();
    Console.WriteLine("OrderID= "+this.OrderId+"\nOrderDate= "+this.OrderDate+"\nCustomerID= "
    +this.CustomerID+"\nTotalAmount= "+this.TotalAmount+"\nStatus= "+this.Status);


    }
}
