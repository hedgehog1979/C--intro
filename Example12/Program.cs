// Вид метода 1: ничего не получает, ничего не возвращает

void Method1 ()
{
    Console.WriteLine("Афтаржжет");
}
// Method1();

// Вид метода 2: ничего не возвращает, но получает какие-то аргументы

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
   
}
// Method21(msg: "Text", count: 4);
// Method21(count: 4, msg: "New Text");


// Вид метода 3: ничего не получает, но что-то возвращает

int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3 ();
// Console.WriteLine (year);


// Вид метода 4: получает какие-то аргументы и что-то возвращает

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(text: "z", count: 10);
// Console.WriteLine(res);

string Method41 (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(text: "z", count: 10);
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
//     {
//         for (int j = 2; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} * {j} = {i*j}");
//         }
//         Console.WriteLine();
//     }


// // Работа с текстом.
//  Дан текст. В тексте требуется все пробелы заменить черточками, маленькие буквы "к" заменить большими буквами "К", а большие "С" - маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы Вас послали вместо нашего милого Винценгероде, "
            + "то Вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// string NewText = Replace(text, ' ', '|');
// Console.WriteLine(NewText);
// Console.WriteLine();

// NewText = Replace(NewText, 'к', 'К');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'с', 'С');
// Console.WriteLine(NewText);
// Console.WriteLine();


int[] array = {1,5,7,3,6,2,1,1};

// int[] array = new int [8];
// for (n = 0; n < array.Length; n++)
// {
//     int array[n] = new int Random();
// }

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i=0; i < array.Length - 1; i++)
    {
        int MinPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPosition]) MinPosition = j;
        }



        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;

    }
}
PrintArray(array);
SelectionSort(array);

PrintArray(array);