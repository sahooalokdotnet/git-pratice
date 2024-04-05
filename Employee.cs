public class Employee
{
    public string FName{get;set;}
    public int Age{get;set {
        if(value>18)
        {    
            Age = value;
        }}
    }
    public string Email{get;set;}
    public int Age{get;set;}
    public string Email{get;set
    {
        if(value.Contains("@"))
        {
            Email = value;
        }
    }}
    public string State{get;set;}
    public string Country {get;set;}
    public int Zip {get;set;}
}