using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegulerExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Regex for Password
            string passExp = @"^(?=.*[A-Z]+)(?=.*[a-z]+)(?=.*[!@#$%&*]+)(?=.*[0-9]+)(?!.*[\s]+).{8,}";
            string emailExpression = @"(?!.*[\s]+)[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+";

            Console.Write("Enter your Email : ");
            string email = Console.ReadLine();
            Console.Write("Enter your Password : ");
            string password = Console.ReadLine();

            Match emailRes = Regex.Match(email, emailExpression);
            Match passRes = Regex.Match(password, passExp);
            
            Console.WriteLine("Email Response : " + emailRes.Success.ToString());
            Console.WriteLine("Password Response : " + passRes.Success.ToString());
        }
    }
}
