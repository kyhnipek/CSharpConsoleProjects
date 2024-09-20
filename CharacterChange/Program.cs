// See https://aka.ms/new-console-template for more information

// Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

// Örnek: Input: Merhaba Hello Algoritma x

// Output: aerhabM oellH algoritmA x

string[] s = Console.ReadLine().Split(" ");

for (int i = 0; i < s.Length; i++)
{
    string temp = "";
    int lastIndex = s[i].Length - 1;
    if (lastIndex > 0)
    {
        string first = s[i][0].ToString();
        string last = s[i][lastIndex].ToString();
        temp = last + s[i].Substring(1, (lastIndex - 1)) + first;
    }
    else
    {
        temp = s[i];
    }
    Console.Write(temp + " ");
}
Console.WriteLine("");