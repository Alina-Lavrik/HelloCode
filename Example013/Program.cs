// Адаптируем с использованием метода

void FillArray(int[] collection)
{
    int Length = collection.Length;   // получить длинну массива
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Next(1, 10); 
        //обратиться к эллемену collection на позицию index и положить туда новое случайное целое число от 1 до 10
        index++;  // index = index + 1
    }
}
void PrintArray(int[] col)          // void который будет печатать массив
{
    int count = col.Length;           // колличество элементов
    int position = 0;                // текущая позиция
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }     
}    
int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];    // new int[10] - создай новый массив в кот. будет 10 элементов

FillArray(array);
array[4] = 4;              // принудительно длбавим пару четверок
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 444);
Console.WriteLine(pos);