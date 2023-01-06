void FillArr (string[] array)
{   for (int i=0; i<array.Length; i++){
        array[i] = Console.ReadLine();}
}   

Console.WriteLine("введите число элементов массива");
int len1 = int.Parse(Console.ReadLine());
string [] Array = new string [len1];
Console.WriteLine("Введите массив столбцом");
FillArr(Array);
