using HL_26_12_2023;

var database = new DataBase();

database.LoadToFile();

database.AddFeedback(Guid.Parse("38ee83c1-709f-4c9d-b31e-09a930c1c89a"), "I love .NET", 5);
database.AddFeedback(Guid.Parse("f4986757-40af-4b47-b8c2-f5df0a21dc4d"), "Test feedback 2", 1);
database.AddFeedback(Guid.Parse("0a26b0bb-be4f-42a1-b5f8-568cfe8e7d1b"), "I have no enemies", 5);

database.SaveToFile();