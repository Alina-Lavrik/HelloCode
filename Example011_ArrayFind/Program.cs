int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;  //возвращает длину или количество элементов массива;
int find = 18;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;   // остановит поиск после нахождения первого нужного номера индекса 
    }
    
    //index = index + 1;
    index++;
}