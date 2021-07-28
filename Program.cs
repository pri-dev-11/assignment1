using System;

namespace Assignment_1
{
    class Account
    {
        string accountNo;
        double accountBalance;
        string accountPassword;
        static string bankName;

        public string AccountNo { get => accountNo; set => accountNo = value; }
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        static Account()
        {
            bankName = "ABC Bank Limited";
        }
        public Account()
        {
            AccountNo = "0000";
            AccountBalance = 0.00;
            AccountPassword = "NA";
        }
        public Account(string num,double balance, string pass)
        {
            AccountNo = num;
            AccountBalance = balance;
            AccountPassword = pass;
        }
        public void displayAccount()
        {
            Console.WriteLine("The account number is: " + AccountNo);
            Console.WriteLine("The account balance is: " + AccountBalance);
            Console.WriteLine("The bank name is: " + bankName);
        }
    }
    class Program
    {
        int no_units;

        public int No_units { get => no_units; set => no_units = value; }
        Program(int units)
        {
            no_units = units;
        }
        public double CalcBill()
        {
            if(no_units < 100)
            {
                return no_units * 1.20;
            }
            else if(no_units >=100 && no_units <= 300*1)
            {
                return (120 + (no_units - 100) * 2);
            }
            else
            {
                return (520 + (no_units - 300) * 3);
            }
            }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter no. of units: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Program p1 = new Program(n);
            double bill = p1.CalcBill();
            Console.WriteLine("The bill of {0} units is: {1} ", n,bill);
            Console.WriteLine();
            Console.WriteLine("Solution to question 2 and 3 combined: ");
            int[] arr = new int[7];
            for(int j=0;j<7;j++)
            {
                arr[j] = 0;
            }
            
            double sum = 0;
            for(int m = 0; m < 5; m++) {
                int i = 1;
                while (i<=30)
            {
                int random_number = new Random().Next(0, 7);
                if(random_number == 5)
                {
                    continue;
                }
                else
                {
                    sum += random_number;
                    arr[random_number]++;
                    i++;
                }
            }
            }
            double strike_rate = sum / 150;
            Console.WriteLine("The total runs scored: " + sum);
            Console.WriteLine("The strike rate is: " + strike_rate);
            for(int k=0;k<7;k++)
            {
                if (k == 5)
                    continue;
                Console.WriteLine("The no. of " + k + " are :" + arr[k]);
            }
            Console.WriteLine();
            Account a1 = new Account("12212676799",25000.00,"rt445@#tr");
            a1.displayAccount();

        }
    }
}
