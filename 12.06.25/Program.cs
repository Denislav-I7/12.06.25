namespace _12._06._25
{
    internal class Program
    {
        public class BankAcount()
        {
            public int Id;
            public double balance;

            public int ID
            {
                get { return Id; }
                set { Id = value; }
            }

            public void Deposit(double amount)
            {
                balance = balance + amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                }
                else
                {
                    Console.WriteLine("Not enough money");
                }
            }

            public override string ToString()
            {
                return $"ID:{Id},Balance:{balance:F2}";
            }


            static void Main(string[] args)
            {
                BankAcount acount = new BankAcount();
                acount.Id = 1;
                acount.Deposit(15);
                acount.Withdraw(5);

                Console.WriteLine(acount.ToString());
            }
        }
    }
}
