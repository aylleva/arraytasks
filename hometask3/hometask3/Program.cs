//task3
string[] words = { "ayla", "ismayil", "nezrin", "anora", "zerife", "anar", "rauf","altun" ,"ruslan"};

for(int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 4)
    {
        Console.WriteLine(words[i]);
    }
}