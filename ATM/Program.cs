// See https://aka.ms/new-console-template for more information

using ATM;

Logs.ReadLog();

User user = new User();
var loggedIn = Operations.Login();

if (loggedIn != null)
{
    Menu.Show();
}
else
{
    loggedIn = Operations.Login();
}






