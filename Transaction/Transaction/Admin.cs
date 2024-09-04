using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    public class Admin
    {
        public int Id { get; set; }
        public string UserType { get; set; }
        public List<User> Users { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Admin(int id, string userType)
        {
            Id = id;
            UserType = userType;
            Users = new List<User>();
            Transactions = new List<Transaction>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void SeeAllUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"Your Id: {user.Id}, Your Username: {user.Username}, Your Salary: {user.Salary}, Your UserType: {user.UserType}");
            }
        }

        public void UpdateUser(int userId, string newUsername, double newSalary)
        {
            var user = Users.Find(u => u.Id == userId);
            if (user != null)
            {
                user.Username = newUsername;
                user.Salary = newSalary;
            }
        }

        public void DeleteUser(int userId)
        {
            Users.RemoveAll(u => u.Id == userId);
        }

        public void SeeTransactions()
        {
            foreach (var transaction in Transactions)
            {
                Console.WriteLine($"Your Amount: {transaction.Amount}, Ypur UserId: {transaction.UserId}, Your Date: {transaction.TransactionDate}");
            }
        }
    }
}
