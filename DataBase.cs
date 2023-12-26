using HL_26_12_2023.Entities;
using HL_26_12_2023.Interfaces;
using System.Text.Json;

namespace HL_26_12_2023;

public class DataBase : IPersistable
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
        if (!_users.Any(us => us.Id.Equals(userId)))
        {
            throw new ArgumentException("User not found", nameof(userId));
        }

        if (rating > 5)
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

    public void PrintAllUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine(user);
        }
    }

    public void SaveToFile()
    {
        using (var writer = new StreamWriter(_usersFileName))
        {
            writer.Write(JsonSerializer.Serialize(_users));
        }

        using (var writer = new StreamWriter(_feedbacksFileName))
        {
            writer.Write(JsonSerializer.Serialize(_feedbacks));
        }
    }

    public void LoadToFile()
    {
        using (var reader = new StreamReader(_usersFileName))
        {
            _users = JsonSerializer.Deserialize<List<User>>(reader.ReadToEnd());
        }

        using (var reader = new StreamReader(_feedbacksFileName))
        {
            _feedbacks = JsonSerializer.Deserialize<List<Feedback>>(reader.ReadToEnd());
        }
    }

    public IEnumerable<Feedback> GetFeedbacksByUserName(string userName)
    {
        User? user = _users.FirstOrDefault(us => us.UserName.Equals(userName));

        if (user is null)
        {
            throw new ArgumentException("User not found", nameof(userName));
        }

        return _feedbacks.Where(fb => fb.UserId.Equals(user.Id));
    }
}