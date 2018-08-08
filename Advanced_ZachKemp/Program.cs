using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ZachKemp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            int choice;
            //Expense expense;
            //ExpenseManager expenseManager;

            do
            {
                Console.WriteLine("My Money Manager - Main Menu");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. New Expense");
                Console.WriteLine("2. View Expense Report");
                Console.WriteLine("3. Remove Expense");
                Console.WriteLine("4. Edit Expense");
                Console.WriteLine("5. Import Data");
                Console.WriteLine("6. Export Data");
                Console.WriteLine("7. Sort the data descending by the date");
                Console.Write("Enter your choice, 0 to quit: ");
                while (int.TryParse(Console.ReadLine(), out choice) == false || choice < 0 || choice > 7) 
                {
                    Console.WriteLine("Incorrect Menu choice");
                    Console.WriteLine("My Money Manager - Main Menu");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("1. New Expense");
                    Console.WriteLine("2. View Expense Report");
                    Console.WriteLine("3. Remove Expense");
                    Console.WriteLine("4. Edit Expense");
                    Console.WriteLine("5. Import Data");
                    Console.WriteLine("6. Export Data");
                    Console.WriteLine("7. Sort the data descending by the date");
                    Console.Write("Enter your choice, 0 to quit: ");
                }
               // expense = new Expense();
                //expenseManager = new ExpenseManager();
                switch (choice)
                {

                    case 1:
                        //expense.Expense();
                        break;

                    case 2:
                       // expenseManager.AddExpense();
                        break;
                    case 3:
                        // expenseManager.
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 0:
                        quit = true;
                        Console.WriteLine("Have a Nice Day!");
                        break;
                }


            } while (quit == false);
            Console.ReadKey();
        }
    }
    public class Expense
    {
        public DateTime date = DateTime.Now;
        public decimal amount = 0;
        public string description = "N/A";

        public Expense()
        {

        }

        public Expense(DateTime date, decimal amount, string description)
        {
            this.date = date;
            this.amount = amount;
            this.description = description;


        }

    }
    public class ExpenseManager
    {
        private List<Expense> expenseList = new List<Expense>();
        public readonly int Count;

        public ExpenseManager()
        {
            Count = expenseList.Count;
        }

        public void AddExpense(Expense currentExpense)
        {
            this.expenseList.Add(currentExpense);
        }

        public static void PrintReport()
        {

        }

        public static bool ImportData(string filePath)
        {
            return false;
        }

        public static bool ExportData(string filePath)
        {
            return false;
        }

        public static bool RemoveExpenseAt(int index)
        {
            return false;
        }

        public static decimal TotalAmount()
        {
            return 0;
        }

        public static Expense GetExpenseAt(int index)
        {
            return new Expense();
        }

        public static void SortByDateDesecending()
        {

        }

        public static bool UpdateExpense(int index, Expense expense)
        {
            return false;
        }

    }
}
