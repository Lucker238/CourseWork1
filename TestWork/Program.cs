// string n = "123a";
// bool check = int.TryParse(n,out int num);
// System.Console.WriteLine(check);

int intMassivLength(string input)
{
    for (int i = 0; i < 1; i++)
    {
        if(int.TryParse(input, out int num))
        {
            return Convert.ToInt32(input);
        }
        else
        System.Console.WriteLine("Вы ввели не число!");
        System.Console.Write("Введите длину задаваемого массива:");
        input = Console.ReadLine();
        i--;
    }
    return 0;
}


System.Console.Write("Введите длину задаваемого массива: ");
int massivLen = intMassivLength(Console.ReadLine());