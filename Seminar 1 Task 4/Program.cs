Console.WriteLine("Введите трехзначное сило и мы покажем Вам последнюю цифру");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99 && num<1000)
{
    Console.WriteLine(num%10);
}
else
{ 
    Console.Write("не то число");
}

