using System.Configuration;

namespace StopwatchPlus
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; //This assists with the App.Config page
        }
    }
}
