namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user1 = new User("test user", "testuser@gmail.com", "Password1");
            user1.ShowInfo();
            Student student1 = new Student("Test User", 99);
            student1.StudentInfo();
            Student student2 = new Student("Test User2", 85);
             student2.StudentInfo();
        }
    }
}
public interface IAccount
{
    bool PasswordChecker(string password);
    void ShowInfo();
}
public class User : IAccount
{
    private static int _idCounter = 0;
    private string _password;
    public int Id { get; }
    public string Fullname { get; set; }
    public string Email { get; }

    public string Password
    {
        get { return _password; }
        set
        {
            if (PasswordChecker(value))
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("");

            }
        }
    }
    public User(string fullname, string email, string password)
    {
        Id = ++_idCounter;
        Id = _idCounter;
        Fullname = fullname;
        Email = email;
        Password = password;
    }
    public bool PasswordChecker(string password)
    {
        if (password.Length < 8)
        {
            Console.WriteLine("Password must be at least 8 characters long.");
            return false;
        }
        if (!password.Any(char.IsUpper))
        {
            Console.WriteLine("Password must contain at least one uppercase letter.");
            return false;
        }
        if (!password.Any(char.IsLower))
        {
            Console.WriteLine("Password must contain at least one lowercase letter.");
            return false;
        }
        if (!password.Any(char.IsDigit))
        {
            Console.WriteLine("Password must contain at least one digit.");
            return false;
        }
        return true;

    }
    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
    }
}
public class Student
{
    private static int _idCounter = 0;
    public int Id { get; }
    public string Fullname { get; set; }
    public int Point { get; }

    public Student(string fullname, int point)
    {
        Id = ++_idCounter;
        Fullname = fullname;
        Point = point;
    }
    public void StudentInfo()
    {
        Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Point: {Point}");
    }
}
