// See https://aka.ms/new-console-template for more information

// Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan.
//  67'den küçük olanların 67 ile olan farklarının toplamını, 
//  büyük ise de 67 ile farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

// Örnek: Input: 56 45 68 77

// Output: 33 101

int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

for (int i = 0; i < arr.Length; i += 2)
{
    if (arr[i] < 67)
    {
        Console.Write(Math.Abs(67 - arr[i]) + Math.Abs(67 - arr[i + 1]) + " ");
    }
    else
    {
        Console.Write(Math.Pow(Math.Abs(67 - arr[i]), 2) + Math.Pow(Math.Abs(67 - arr[i + 1]), 2) + " ");
    }
}
Console.WriteLine();