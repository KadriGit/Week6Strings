
string userName = "Kadri";

Console.WriteLine(userName.Length);

Console.WriteLine($"The first letter in your name is {userName[userName.Length -1]}");

//replace
// a - 4
string UpdateUserName = userName.Replace("a", "4").Replace("i","3");
Console.WriteLine(UpdateUserName);