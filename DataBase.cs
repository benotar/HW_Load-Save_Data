using HL_26_12_2023.Entities;

namespace HL_26_12_2023;

public class DataBase
{
    private List<User> _users;

    private List<Feedback> _feedbacks;
    
    private const string _usersFileName = "users.json";
    
    private const string _feedbacksFileName = "feedbacks.json";

    public DataBase()
    {
        _users = new List<User>();
        _feedbacks = new List<Feedback>();
    }

}
