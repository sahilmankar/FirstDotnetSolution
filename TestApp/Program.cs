using OrderProcessingLib;
using CatalogLib;
using CRMLib;


//product class
Product p1=new Product();   //default constructor
p1.Display();             

Product p=new Product();
p.Id=1;
p.Title="Biscuit";
p.Description="good quality Biscuit";
p.StockAvailalbe=20;
p.UnitPrice=10;
p.Display();

Product p2=new Product(4,"Balaji wafers","spicey and salty",9.99,120); //parameterized constructor
p2.Display();


//Customer Class

Customer c=new Customer();
c.Display();

Customer c2=new Customer();
c2.Id=10;
c2.FirstName="abhay";
c2.Lastname="navle";
c2.ContactNumber="4261836283";
c2.Email="abc@gmail.com";

c2.Display();

Customer c3=new Customer(11,"shubham","teli","7028173295","shubhamteli@gmail.com");
c3.Display();


//Order class
Order o1=new Order();
o1.Display();

Order o2=new Order();
o2.OrderId=100;
o2.OrderDate=new DateTime(2020,10,01);
o2.CustomerID=c2.Id; //assignig c2 id
o2.TotalAmount=404.20;
o2.Status="pending";
o2.Display();

Order o3=new Order(5,new DateTime(2022,12,08),c3.Id,540.25,"Completed");
o3.Display();
