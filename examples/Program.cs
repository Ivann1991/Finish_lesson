// написать программу, которая из имеющегося массива строк формирует массив из cтрок, длина для которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
Console.Clear();
int CountElement = EnterUserNum("Массив из скольки элементов будем заполнять?! ", "ошибка ввода");
string[] UserArray = EnterArrayElement(CountElement);
int Count = 0;
for (int i = 0; i < UserArray.Length; i++)
    if (UserArray[i].Length <= 3)
        Count++;
string[] resultArray = new string[Count];
int j = 0;
for (int i = 0; i < UserArray.Length; i++)
    if (UserArray[i].Length <= 3)
    {
        resultArray[j] = UserArray[i];
        j++;
    }
if (j == 0)
{
    Console.Write("[");
    Console.Write(String.Join(", ", UserArray));
    Console.Write("]");
    Console.Write(" ---> [empty]");
}
else
{
    Console.Write("[");
    Console.Write(String.Join(", ", UserArray));
    Console.Write("]");
    Console.Write(" ---> [");
    Console.Write(String.Join(", ", resultArray));
    Console.Write("]");
}


/////////////////////////// методы
int EnterUserNum(string message, string errorMessage)        // количество элементов массива, ввод с клавиатуры
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return Math.Abs(num);
        Console.WriteLine(errorMessage);

    }
}

string EnterElement(string message)        // элементы массива, ввод с клавиатуры
{
    while (true)
    {
        Console.Write(message);
        string num = Console.ReadLine() ?? "";
        return num;

    }
}

string[] EnterArrayElement(int size)                            // Заполнение элементов массива с клавиатуры

{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        string element = EnterElement($"заполни {i + 1}-й элемент ");

        array[i] = element;
    }
    return array;
}
