using HL_26_12_2023;

var database = new DataBase();

database.LoadToFile();


foreach(var item in database.GetFeedbacksByUserName("benotar"))
{
    Console.WriteLine(item);
}

