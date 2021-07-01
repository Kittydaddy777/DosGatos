
namespace StopwatchPlus
{
    interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string StopTime { get; set; }

        string RunDate { get; set; }

        string Password { get; set; }

        string PersonInfo { get; }
    }
}
