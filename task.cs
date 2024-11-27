namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Random rn = new Random();
        int number = rn.Next(1, 20);

        Console.WriteLine("Привет! Давай сыграем в игру угадай число, я задаю число от 1 до 20, твоя аздача отгадать это число с 5 попыток.");

        int x = 0;
        while (x < 6) 
        {
            if (x==5)
            {
                Console.WriteLine("Увы но вашы попытки закончились.. Загаданное число --> "+ number);
                break;
            }

            Console.WriteLine("Введи число: ");
            int inp = Convert.ToInt16(Console.ReadLine());
            
            
            if (inp > number)
            {
                Console.WriteLine("Твоё число больше загаданного!");
                x = x+1;
            }
            else if (inp < number)
            {
                Console.WriteLine("Твоё число меньше загаданного!");
                x = x+1;
            }
            if (inp == number) 
            {
                Console.WriteLine("Молодец ты выиграл!");
                x = 10;
            }
        }
    }
}
