// See https://aka.ms/new-console-template for more information

// Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.
// Örnek: Input: Merhaba Umut Arya
// Output: True False True

string[] s = Console.ReadLine().ToLower().Split(" ");

for (int i = 0; i < s.Length; i++)
{
    Console.Write(FindSecondConsonant(s[i]) + " ");
}
Console.WriteLine();

bool FindSecondConsonant(string p)
{
    for (int i = 1; i < p.Length; i++)
    {
        if (IsConsonant(p[i]) && IsConsonant(p[i - 1]))
        {
            return true;
        }
    }
    return false;
}

bool IsConsonant(char c)
{
    return !"aeıioöuü".Contains(c);
}