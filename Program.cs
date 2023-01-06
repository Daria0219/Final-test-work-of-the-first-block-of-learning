/* void FillArr (string [] array)
{   for (int i=0; i < array.Length; i++){
        array[i] = Console.ReadLine();}
}   

void PrintArray (string [] arr)
{   Console.Write(arr[0]);
    int pos=1;
    while (pos < arr.Length)
        {Console.Write($", {arr[pos]}");
        pos++;}
    }

Console.WriteLine("введите число элементов массива");
int len1 = int.Parse(Console.ReadLine());
string [] Array = new string [len1];
Console.WriteLine("Введите массив столбцом");

FillArr(Array);
Console.Write("Исходный массив: ");
PrintArray(Array);

void ChangeMassive (string[]arr){
List<string> newlist = new List<string>();
for (int i=0; i < arr.Length; i++){
    if (arr[i].Length<=3) {
        newlist.Add(arr[i]);
        }
    }
string [] newArr = newlist.ToArray();
PrintArray(newArr);
}

Console.WriteLine();
Console.Write("Преобразованный массив: ");
ChangeMassive(Array);
*/

// Второй способ решения

void FillArr (string [] array)
{   for (int i=0; i < array.Length; i++){
        array[i] = Console.ReadLine();}
}   

void PrintArray (string [] arr)
{   Console.Write(arr[0]);
    int pos=1;
    while (pos < arr.Length)
        {Console.Write($", {arr[pos]}");
        pos++;}
    }

Console.WriteLine("введите число элементов массива");
int len1 = int.Parse(Console.ReadLine());
string [] Array = new string [len1];
Console.WriteLine("Введите массив столбцом");

FillArr(Array);
Console.Write("Исходный массив: ");
PrintArray(Array);

void NewMassive (string[]arr){
int len2 = 0;
for (int i=0; i < arr.Length; i++){
    if (arr[i].Length<=3) {
        len2++;}
    }
string [] newArr = new string [len2];
int k=0;
for (int i=0; i < arr.Length; i++){
    if (arr[i].Length<=3) {
        newArr[k]=arr[i];
        k++;
    }}
PrintArray(newArr);
}

Console.WriteLine();
Console.Write("Преобразованный массив: ");
NewMassive(Array);
