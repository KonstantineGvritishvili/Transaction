using Transaction;

Admin admin = new Admin(1, "Admin");
User user1 = new User(3, 968, "Alice", "User");
User user2 = new User(2, 54325, "Bob", "User");

admin.AddUser(user1);
admin.AddUser(user2);

user1.TransferMoney(211, user2, admin);
user2.SeeMySalary();

admin.SeeAllUsers();
admin.SeeTransactions();