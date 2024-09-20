// See https://aka.ms/new-console-template for more information

// Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir. 
// Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir. 
// Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir. 
// Kategoriler isteğe bağlı olarak belirlenebilir.

// Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri

// Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.

// Kullanılması gereken teknikler:

// Kategoriler pre-defined kullanılabilir.

using VotingApp;

Categories categories = new Categories();
User user = new User();
Vote vote = new Vote();

Utils.AddMinus();
Console.WriteLine("Oylama uygulamasına hoşgeldiniz.");
Utils.AddMinus();

Console.Write("Oylama yapabilmek için lütfen kullanıcı adınızı giriniz: ");
string usr = Console.ReadLine();
if (!user.UserCheck(usr))
{
    Console.Write("Kullanıcı bulunamadı, üye olmak için kullanıcı adınızı giriniz: ");
    usr = Console.ReadLine();
    user.UserRegister(usr);
    Utils.AddMinus();
}
categories.ListCategories();
Console.Write("Oy vermek istediğiniz kategoriyi seçiniz : ");
int selection = int.Parse(Console.ReadLine());
vote.VoteCategory(selection);