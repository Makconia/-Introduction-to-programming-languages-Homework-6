// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
 
System.Console.WriteLine("Введите число: ");
int numb = InputData();
UserNumber(numb);



 
int InputData()
{
    int number = Int32.Parse(Console.ReadLine());
    return number;
}

 
static void UserNumber(int number)
{
    int count = 0;
    while (number != 0)
    {
        if (number > 0) count++;
        System.Console.WriteLine("Введите еще число или '0' для остановки");
        number = Int32.Parse(Console.ReadLine());
    }
    System.Console.WriteLine("Количество чисел больше 0 = " + count);
}
