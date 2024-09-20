// See https://aka.ms/new-console-template for more information
// Ekrandan girilen n tane integer ikililerin toplamını alan, 
// eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, 
// sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.
// Örnek Input: 2 3 1 5 2 5 3 3
// Output: 5 6 7 36

int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

foreach (var item in arr)
{
    Console.WriteLine(item);
}

for (int i = 0; i < arr.Length; i += 2)
{
    if (arr[i] == arr[i + 1])
    {
        Console.Write(Math.Pow((arr[i] + arr[i + 1]), 2) + " ");
    }
    else
    {
        Console.Write(arr[i] + arr[i + 1] + " ");
    }
}
Console.WriteLine();