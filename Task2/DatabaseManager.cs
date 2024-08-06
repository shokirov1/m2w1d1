using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d1.Task2
{
    public static class DatabaseManager
    {
        public static string? connection;

        public static void OpenConnection()
        {
            if (connection == null)
            {
                Console.WriteLine("Connection ON.");
            }
            else
            {
                Console.WriteLine("Connection was open.");
            }
        }
        public static void CloseConnection() 
        {
            if (connection == null)
            {
                Console.WriteLine("Connection was open.");
            }
            else
            {
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
