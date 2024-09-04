using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    public class User
    {
        public int Id { get; set; }
        public double Salary { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }

        public User(int id, double salary, string username, string userType)
        {
            Id = id;
            Salary = salary;
            Username = username;
            UserType = userType;
        }

        public void TransferMoney(double amount, User recipient, Admin admin)
        {
            if (amount > 0 && amount <= Salary)
            {
                Salary -= amount;
                recipient.Salary += amount;
                var transaction = new Transaction(amount, Id);
                admin.Transactions.Add(transaction);
                FileManager.LogTransactionToFile(transaction);
            }
        }

        public void SeeMySalary()
        {
            Console.WriteLine($"My Salary: {Salary}");
        }

        public void SeeUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($" Your Id: {user.Id}, Your Username: {user.Username}, Your Salary: {user.Salary}, Your UserType: {user.UserType}");
            }
        }
    }
}
