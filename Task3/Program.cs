var bankAccount = new BankAccount(1200);
bankAccount.AccountNumber = Convert.ToInt32(Console.ReadLine());
bankAccount.Owner = Console.ReadLine();

bankAccount.TopUp(123);

bankAccount.Withdraw(122);

System.Console.WriteLine(bankAccount.PrintStatement());

class BankAccount
{
    public int AccountNumber { get; set; }
    private decimal balance  { get; set; }
    public string Owner { get; set; }
    public BankAccount(decimal a)
    {
        balance=a;
    }
    public void TopUp(decimal amount)
    {
        balance+=amount;  
    }
    public void Withdraw(decimal amount)
    {
        balance-=amount;
    }
    public string PrintStatement()
    {
        return $"{balance}";
    }
}