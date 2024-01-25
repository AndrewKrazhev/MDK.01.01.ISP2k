internal class Program
{
    private static void Main(string[] args)
    {
        string myString;
        int helthPower = 100; 
        int carmaVal = 0;
        string palayerName = "noname";
        /*
        Console.Write("Ваше здоровье: ");
        Console.WriteLine(helthPower);
        myString = $"Ваше здоровье: {helthPower}";
        Console.WriteLine(myString);
        */
        //инкапсуляция текстовой переменной.
        Console.WriteLine($"Ваше здоровье: {helthPower}, карма {carmaVal}");

        //вывод на экран варианта сцены.
        Console.WriteLine("Вы подошили к воротам техникума...\nВаши действия?");
        Console.WriteLine("1. Пойти на пары");
        Console.WriteLine("2. Уйти домой");
        Console.WriteLine("3. Пойти за шавой");
        Console.Beep();
        string userChoose = Console.ReadLine();
        Console.WriteLine("Выбор " + userChoose[0]);
        
        //Использование конструкции if then else.
        /*
        if (userChoose[0] == '1') 
            { 
                Console.WriteLine("Вы выбрали 1");
            }
        if (userChoose[0] == '2')
        {
            Console.WriteLine("Вы выбрали 1");
        }
        if (userChoose[0] == '3')
        {
            Console.WriteLine("Вы выбрали 1");
        }
        else
        {
            Console.WriteLine("Такого варианта нет, повторите ввод");
        }
        */
        switch (userChoose[0])
        {
            case '1':
                Console.WriteLine("Вы выбрали 1");
            break;
            case '2':
                Console.WriteLine("Вы выбрали 2");
            break;
            case '3':
                Console.WriteLine("Вы выбрали 3");
            break;
            default:
                Console.WriteLine("Такого варианта нет, повторите ввод");
                break;
        }
    }
}