namespace CRMLib;
public class Customer
{
    

    public int Id{get;set;}
    public string FirstName{get;set;}
    public string Lastname{get;set;}
    public string ContactNumber{get;set;}
    public string Email{get;set;}
    public Customer()
    {
        Id =0;
        FirstName = "Sahil";
        Lastname = "Mankar";
        ContactNumber = "1234567890";
        Email = "sahilmankar311@gmail.com";
    }

    public Customer(int id, string firstName, string lastname, string contactNumber, string email)
    {
        Id = id;
        FirstName = firstName;
        Lastname = lastname;
        ContactNumber = contactNumber;
        Email = email;
    }

public void Display(){
    Console.WriteLine();
    Console.WriteLine("ID= "+this.Id+"\nFirstName= "+this.FirstName+
    "\nLastName= "+this.Lastname+"\nContactNumber= "+this.ContactNumber+"\nEmail= "+this.Email);
}
    

}
