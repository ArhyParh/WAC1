// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]
Main();
void Main()
{
    int[] a = FeelMass(8);
    Print(a);

}
int[] FeelMass(int size)
{
    Random rnd = new Random();
    int[] back = new int[size];
    for (int i = 0; i < size; i++)
    {
back [i] = rnd.Next(0, 100);
    }
 return back;
}
void Print(int[] array){
 for(int i =0; i <array.Length;i++){
    Console.Write(array[i]+" ");
 }
}