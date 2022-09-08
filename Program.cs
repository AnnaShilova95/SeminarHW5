/*Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/Метод, создающий массив из положительных трехзначных чисел.

int[] MyArray (int size){
    int[] array = new int [size];
    for (int i=0; i< size; i++){
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

/Метод, выводящий массив на экран

void ShowArray (int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write( $"{array[i]} ");
    }
}

/Метод, считающий количество четных чисел в массиве.

void Quantity (int []array){
    int res = 0;
    for (int i=0; i<array.Length; i++){
        if(array[i] %2 == 0) 
        res=res+1;
    }
    Console.WriteLine($"Количество четных чисел в массиве равно {res} ");
}

Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int [] array = MyArray(size);

/Вызов методов.

ShowArray(array);
Quantity (array);


//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray (int size, int min, int max){
    int[] array = new int [size];
    for (int i=0; i< size; i++){
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void ShowArray (int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write( $"{array[i]} ");
    }
}

void Sum (int [] array){
    
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if(i %2 != 0) sum+=array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size, min, max);

ShowArray(array);
Sum (array);


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Создаем массив

double [] CreateRandomArray (int size, int min, int max){
    double[] array = new double [size];
    for (int i=0; i< size; i++){
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void ShowArray (double [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write( $"{array[i]} ");
    }
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

/Метод, который ищет максимальное значение и минимальное и затем находит разницу
void Sum (double [] array){
    double maximum = 0;
    double minimum = 0;
    for (int i = 0; i < array.Length; i++){
        if (array [i] > maximum) maximum = array [i];
        if (array[i] < minimum) minimum = array [i];
    }
    Console.WriteLine("Разница максимального и минимального:  "+(maximum - minimum));

}

double [] array = CreateRandomArray(size, min, max);

ShowArray(array);
Sum (array);

*/