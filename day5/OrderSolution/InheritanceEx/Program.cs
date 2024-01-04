using Library;
using Mathematics;

Books shelf = new Books();

shelf[3] = "Let us C++";

string bookTitle = shelf[3];

Console.WriteLine("Book title : " + bookTitle);


int? marks = null;
Console.WriteLine("type of marks'" + marks+"'");
// Console.WriteLine(marks);


 UtilityManager.Calculate(7.0f);
// int a = 4, b = 5;
// UtilityManager.Swap(ref a, ref b);
UtilityManager.ShowNames("Ameya", "Saurabh", "Somesh");


// inheritance without extending
MathEngine e = new MathEngine();
int result1 = e.Adition(56,56);
int result2 = e.Subtraction(56,56);
int result3 = e.Multiplication(56,56);
int result4 = e.Division(56,56);

Console.WriteLine(result1 + ", "+ result2+ ", "+ result3 + ", "+ result4);