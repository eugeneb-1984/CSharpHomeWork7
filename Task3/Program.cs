/* 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            randArray[i,j] = rnd.Next(0,10);
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

//выводим average по столбцам
void PrintColAverage( int [,] array) {
    for (int col = 0; col < array.GetLength(1); col++) {
        double sumCol = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sumCol += array[row, col];
        }
        Console.WriteLine($"Avg столбца {col+1}: {sumCol / array.GetLength(0)}");
    }
}

int row = GetNumber("Сколько строк в массиве? ");
int col = GetNumber ("Сколько столбцов в массиве? ");
int [,] userArray = InitRandArray(row, col);
PrintArray(userArray);
PrintColAverage(userArray);