
//Q1

using System.Runtime.InteropServices;
using System.Text;

string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);

//Q2

string n1 = "clean code";
string n2 = "clean code";
Console.WriteLine(Object.ReferenceEquals(n1, n2)); // true

//Q3

StringBuilder sb = new StringBuilder();
sb.Append("book list");
sb.Append(" - Updated");
Console.WriteLine(sb.ToString());

//Q4

StringBuilder sb02 = new StringBuilder("book list");
sb02.Replace("book list", "library");
Console.WriteLine(sb02.ToString());

//Q5

string title02 = "clean code";
int pages = 464;
string sentence = "book : " + title02 + " , pages : " + pages;
Console.WriteLine(sentence);

//Q6

string title03 = "clean Code";
int pages01 = 464;

string sentence01 = $"Book: {title03}, Pages: {pages01}";
Console.WriteLine(sentence01);

//Q7
string title04 = "clean code";
int pages02 = 464;
string sentence02 = $"Book: {title04}, Pages: {pages02}";
Console.WriteLine(sentence02);

//Q8

int pages03 = 464;

    if (pages03 > 300)
    {
        Console.WriteLine("Long book");
    }
    else
    {
    Console.WriteLine("Short book");
    }

//Q9

    int pages04 = 464;
    bool isAvailable = true;

    if (pages04 > 300 && isAvailable)
    {
    Console.WriteLine("You can borrow this book");
    }

//Q10

        string title05 = "Refactoring";
        switch (title05)
        {
        case "clean code":
        Console.WriteLine("Great choice!");
        break;
        case "Refactoring":
        Console.WriteLine("Nice pick");
        break;
        default:
        Console.WriteLine("Never heard of it");
        break;
}

//Q11

int pages05 = 464;
string sizelabel = pages05 > 300 ? "Long book" : "Short book";
Console.WriteLine(sizelabel);




//Q12

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for (int i01 = 0; i01 < books.Length; i01++)
{
    Console.WriteLine(books[i01]);
}

//Q13

int i02 = 0;
while (i02 < books.Length)
{
    Console.WriteLine(books[i02]);
    i02++;
}

//Q14

int count = 0;
do
{
    Console.WriteLine("Checking book...");
    count++;
} while (count < 3);

//Q15

foreach (string book in books)
{
    Console.WriteLine(book);
}

//Q16


foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }
    Console.WriteLine(book);
}

//Q17

foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue; 
    }
    Console.WriteLine(book);
}


