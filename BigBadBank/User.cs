namespace BigBadBank;

public class User(int id, string? userName, int money)
{
    public int Id {get; set;} = id;
    public string? UserName {get; set;} = userName;
    private int Money {get; set;} = money;
    
    public void HandleWithdrawal( int amount)
    {
        if (amount > Money)
        {
            Console.WriteLine("not enough money");
            return;
        }
        
        Money = Money - amount;
        Console.WriteLine("balance = " + Money);
    }
    
    public void HandleDeposit( int amount)
    {
        Money = Money + amount;
        Console.WriteLine("balance = " + Money);
    }
}