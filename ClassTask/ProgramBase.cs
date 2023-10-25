namespace ClassTask
{
    internal class ProgramBase
    {
        void Create(string name, string surname, string password)
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter SurName : ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter PassWord : ");
            password = Console.ReadLine();
        }
    }
}