
string userName = "Kadri";

Console.WriteLine(userName.Length);

Console.WriteLine($"The first letter in your name is {userName[userName.Length -1]}");

//a-counter 

int counter = 0;
for(int i = 0; i < userName.Length; i++)
{
    if (userName[i] == 'a')
    {
        counter++; // counter = counter + 1
    }

}
Console.WriteLine($"Yor first name has {counter} a-letters");