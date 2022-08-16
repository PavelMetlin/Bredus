// задача 2
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{

    int counter = Convert.ToString(num).Length;
    int prog = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        prog = num - num % 10;
        result = result + (num - prog);
        num = num / 10;
    }
    return result;
}

int sumNum = SumNum(num);
Console.WriteLine("Сумма цифр в числе " + sumNum);