/*

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

*/

//Принимаем число на ввод
int GetNumber(string message) {
    bool isNumber = false;
    int Number = 0;
    while(!isNumber) {
        Console.Write(message);
        string input = Console.ReadLine();
        if(Int32.TryParse(input, out Number)) {
            isNumber = true;
        }
        else {
            Console.WriteLine("Вы ошиблись при вводе. Введите число.");
        }
    }
    return Number;
}

//выводим значения массива
void PrintArray (int [,] array) {

    for (int row = 0; row < array.GetLength(0); row++) {
        for (int column = 0; column < array.GetLength(1); column++) {
            Console.Write($"{array[row, column]} ");
        }    
        Console.WriteLine();
    }
}

//выводим значение элемента по позиции
void PrintElement (int [,] targetArray, int i, int j) {
    string result = string.Empty;
    if (i >targetArray.GetLength(0) || j > targetArray.GetLength(1)) result = "Такого элемента в массиве нет";
    else result = $"Значение элемента [{i}, {j}]: {targetArray[i,j]}";
    Console.WriteLine(result);
}

// задаём массив по условиям задачи
int [,] givenArray = new int [,] 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int row = GetNumber("Введите строку: ");
int col = GetNumber("Введите столбец: ");
Console.WriteLine();
Console.WriteLine("Заданный массив:");
PrintArray(givenArray);
Console.WriteLine();
PrintElement(givenArray, row, col);