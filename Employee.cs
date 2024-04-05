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
}