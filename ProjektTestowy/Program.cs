using System.Diagnostics.CodeAnalysis;
string text = "In the source of code, we find our way,\r\nA guiding source in night and day.\r\nEach function’s source, a spark of mind,\r\nFrom source to finish, we’re aligned.";
text = text.Replace("source", "CODE");
Console.WriteLine(text);
int a = 50;
int b = 30;
int c = a-b;
var Decimal = 1/27m;
var Double = 1/27d;
Console.WriteLine($"c = 50-30, so the value of c is {c}");
Console.WriteLine($"1/27 with decimal is {Decimal}\n\n1/27 in double is {Double}");


var sum = 0;
for (int i = 12; i <=73; i++){
    if (i % 2 == 0){
        sum += i;
    }
}
Console.WriteLine($"the sum of all numbers from 12 to 73 divisible by 2 is {sum}");
treeGenerator();




void treeGenerator()
{
    if (int.TryParse(Console.ReadLine(), out int n))
    {
        Tree(n);
    }
    else
    {
        Console.WriteLine("wrong number");
        treeGenerator();
    }
}

void Tree(int n)
{
    for (int i = 1; i <= n; i++)
    {
        string spaces = new string(' ', n - i);
        string stars = new string('*', 2 * i - 1);
        Console.WriteLine(spaces + stars);
    }
}