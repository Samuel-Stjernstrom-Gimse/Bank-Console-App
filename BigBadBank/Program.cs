using BigBadBank;

Console.WriteLine("Hello!");

string? name;
int money;

InitUser();
{
    var user = new User(23, name, money);
    HandleInputs(user);
}


return;
void HandleInputs(User user)
{
    while (true)
    {
        Console.WriteLine("Enter 'D' for Deposit or 'W' for Withdrawal:");
        var input = Console.ReadLine()!.ToUpper(); 
        
        switch (input)
        {
            case "D":
            {
                Console.WriteLine("Enter deposit amount:");
                var depositAmount = Convert.ToInt32(Console.ReadLine());
                user.HandleDeposit(depositAmount); 
                break;
            }
            case "W":
            {
                Console.WriteLine("Enter withdrawal amount:");
                var withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                user.HandleWithdrawal(withdrawalAmount); 
                break;
            }
            default:
                Console.WriteLine("Invalid input. Please try again.");
                continue; 
        }

        Console.WriteLine("Do you want to perform another transaction? (Y/N)");
        var continueInput = Console.ReadLine()!.ToUpper();

        if (continueInput != "Y")
            break; 
    }
}

void InitUser()
{
    Console.WriteLine("Enter your name:");
    name = Console.ReadLine();

    Console.WriteLine("Enter starting money:");
    money = Convert.ToInt32(Console.ReadLine());
}