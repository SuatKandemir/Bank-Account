
using Bank_Counts;

class Program
{
    static void Main()
    {
        Account customerAccount = new Account("1453", "Suat Kandemir", 1000);

        customerAccount.BalanceInquiry();
        customerAccount.DepositMoney(500);
        customerAccount.WithdrawMoney(200);
        customerAccount.BalanceInquiry();
        Console.WriteLine(customerAccount);
    }
}
