// Найти максимум из 9 чисел с использованием массива

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19};
// array[0] = 12;
// Console.WriteLine(array[0]);

// int a1 = 112125;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 313;
// int b3 = 23111;
// int c3 = 33;

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);