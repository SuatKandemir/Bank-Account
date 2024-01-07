
using Bank_Counts;

class Program
{
    static void Main()
    {
        Account customerAccount = new Account("1453", "Suat Kandemir", 1000);

        customerAccount.BalanceInquiry();
        customerAccount.DepositMoney(800);
        customerAccount.WithdrawMoney(100);
        customerAccount.BalanceInquiry();
        Console.WriteLine(customerAccount);
    }
}
