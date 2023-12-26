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

    public void AddUser(string userName, string? realName)
    {
        if (_users.Any(us => us.UserName.Equals(userName)))
        {
            throw new ArgumentException("Username already exists", nameof(userName));
        }

        _users.Add(new User
        {
            UserName = userName,
            RealName = realName
        });
    }

    public void AddFeedback(Guid userId, string text, uint rating)
    {
        if(!_users.Any(us => us.Id.Equals(userId)))
        {
            throw new ArgumentException("User not found", nameof(userId));
        }

        if(rating > 5)
        {
            throw new ArgumentException("Rating out of range", nameof(rating));
        }

        _feedbacks.Add(new Feedback
        {
            UserId = userId,
            Text = text,
            Rating = rating
        });
    }
}
