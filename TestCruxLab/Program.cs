using System.Text.RegularExpressions;

namespace TestCruxLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\TestCruxLab\TestCruxLab\test'.txt"))
            {
                string? s;
                while ((s = sr.ReadLine()) != null)
                { 
                    Password ps = new Password(s);
                    int countLetter = ps.Example.Count(_ => _.Equals(ps.Letter));
                    if (countLetter <= ps.End && countLetter >= ps.Start)
                        Count++;
                }
            }
            Console.WriteLine($"Count: {Count}");
        }
    }

    public class Password
    {
        public string Example { get; set; }
        public char Letter { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        public Password(string password)
        {
            Letter = password.First();
            Start = Int32.Parse(password[2].ToString());
            End = Int32.Parse(password[4].ToString());
            Example = password.Substring(password.IndexOf(":"));
        }

    }
}
