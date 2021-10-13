//Изменение Миши


// Определить, равен ли квадрат заданного трехзначного числа кубу суммы цифр этого трехзначного числа. Если равкн вывести true, напротив false.

// Вводим и записываем число в переменную input
string inputStr = Console.ReadLine();
int input = Convert.ToInt32(inputStr);

// сумма цифр числа input
int inputSum = 0;

// для каждой цифры из числа input 
foreach(char c in inputStr){
    // преобразуем из char в string
    var strC = Convert.ToString(c);
    // прибавляем к сумме число из strC
    inputSum += Convert.ToInt32(strC);
} 

bool result = Math.Pow(input, 2) == Math.Pow(inputSum, 3);
Console.WriteLine(result);