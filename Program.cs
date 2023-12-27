using HL_26_12_2023;
using HL_26_12_2023.Entities;

var database = new DataBase();

database.LoadToFile();

//foreach (var item in database.GetFeedbacksByUserName("benotar"))
//{
//    Console.WriteLine(item);
//}

//User us = database.GetUserByFeedbackID(Guid.Parse("48a1c912-0e11-4731-a7ba-c0d282c15ad7"));
//Console.WriteLine(us);

//Console.WriteLine(database.GetAverageRatingByUserName("benotar"));

database.PrintAllUsers();
database.PrintAllFeedbacks();

database.RemoveUserAndFeedbacksByUserID(Guid.Parse("38ee83c1-709f-4c9d-b31e-09a930c1c89a"));
Console.WriteLine();

database.PrintAllUsers();
database.PrintAllFeedbacks();
