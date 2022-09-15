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

string[] createInputMassiv(int length)
{
    string[] result = new string[length];
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"Введите элемент массива №{i+1}: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

int outputMassivLen(string[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i].Length < 4) result++;
    }
    return result;
}

string[] sortedMassiv(string[] input, int length)
{
    string[] result = new string[length];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i].Length < 4)
        {
            result[j] = input[i];
            j++;
        }
    }
    return result;

}

string showMassiv(string[] input)
{
    return string.Join(", ", input);
}

Console.Clear();

System.Console.Write("Введите длину задаваемого массива: ");
int massivLen = intMassivLength(Console.ReadLine());

string[] massiv = createInputMassiv(massivLen);

int len = outputMassivLen(massiv);

System.Console.WriteLine(len);