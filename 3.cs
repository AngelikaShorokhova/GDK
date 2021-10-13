// Написать программу, которая бы по введенному номеру еденицы измерения (1 - киллограмм, 2 - милиграмм, 3 - грамм, 4 - тонна, 5 - центнер) и в массе М выдавала бы соответствующее значение массы в килограммах.

Console.Write("Введите единицу измерения (1 - киллограмм, 2 - милиграмм, 3 - грамм, 4 - тонна, 5 - центнер): ");
int measure = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите массу: ");
double mass = Convert.ToDouble(Console.ReadLine());
var result;

switch (measure)
{
    case 1:
        // Выводим как есть
        result = mass;
        break;
    case 2:
        // Переводим милиграмм -> килограмм
        result = mass * 0.000001;
        break;
    case 3:
        // Переводим грамм -> килограмм
        result = mass * 0.001;
        break;
    case 4:
        // Переводим тонна -> килограмм
        result = mass * 1000;
        break;
    case 5:
        // Переводим центнер -> килограмм
        result = mass * 50;
        break;
    default:
        // Пишем ноль, т.к. не ясно какая единица измерения (некорректный ввод)
        result = 0;
        break;
}

if (result == 0) {
    Console.Write("Некорректный ввод");
} else {
    Console.Write("Масса в килограммах: {0}", result);
}