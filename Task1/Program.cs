/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

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

//создаём двумерный массив случайных целых чисел с заданным кол-вом элементов.
int [,] InitRandArray(int row, int col) {

    Random rnd = new Random();
    int [,] randArray = new int [row, col];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            randArray[i,j] = rnd.Next(-101,101);
        }     
    }
    return randArray;
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

int row = GetNumber("Сколько строк будет в массиве? ");
int col = GetNumber("Сколько столбцов будет в массиве? ");
int [,] userArray = InitRandArray(row, col);
Console.WriteLine($"Заданный массив:");
PrintArray(userArray);