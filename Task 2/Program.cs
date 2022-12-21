// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InputNumber("Введите значение b1 = ");
double k1 = InputNumber("Введите значение k1 = ");
double b2 = InputNumber("Введите значение b2 = ");
double k2 = InputNumber("Введите значение k2 = ");
CalculationXY(out double x, out double y);
Print(x, y);



int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}


void CalculationXY(out double x, out double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}


void Print(double number, double number2)
{
    Console.WriteLine($"Точка пересечения: ({number}; {number2})");
}
