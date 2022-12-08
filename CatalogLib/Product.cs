namespace CatalogLib;
public class Product
{
    

    public int Id{get;set;}
    public string Title{get;set;}
    public string Description{get;set;}
    public double UnitPrice{get;set;}
    public int StockAvailalbe{get;set;}

public Product()
    {  
        Id = 0;
        Title = "Add Title";
        Description = "Add description";
        UnitPrice =0;
        StockAvailalbe = 0; 
    }

    public Product(int id, string title, string description, double unitPrice, int stockAvailalbe)
    {
        Id = id;
        Title = title;
        Description = description;
        UnitPrice = unitPrice;
        StockAvailalbe = stockAvailalbe;
       
    }


    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine( "Id= "+this.Id+"\nTitle= "+this.Title+"\nDescription= "+this.Description+
        "\nUnitPrice= "+this.UnitPrice+"\nStockAvailalbe= "+this.StockAvailalbe);
    }
}

