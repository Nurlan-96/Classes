#region Reverse 
//using System.Text;

//Console.WriteLine(Reverse("Salam necesen"));
//string Reverse (string text)
//{
//    StringBuilder builder = new StringBuilder();
//    for (int i = text.Length - 1; i >= 0; i--)
//    {
//        builder.Append(text[i]);
//    }
//    return builder.ToString();
//}
#endregion

#region login
//using Reverse.Models;
//Console.WriteLine("Write your username");
//string user = Console.ReadLine();
//Console.WriteLine("Write your password");
//string pass = Console.ReadLine();

//Account account1 = new(username: "lorem123", password: "123456*");
//Console.WriteLine(account1.Login(user,pass));
#endregion

#region factorial
//using Reverse.Models;
//using System.Threading.Channels;

//Factorial factorial1 = new(3);
//Factorial factorial2 = new(10);
//Console.WriteLine(factorial1.Function(3));
//Console.WriteLine(factorial2.Function(10));
#endregion

using Reverse.Models;

int Value1= int.Parse(Console.ReadLine());
char Symbol = char.Parse(Console.ReadLine());
int Value2= int.Parse(Console.ReadLine());

Calculator calculation = new Calculator(Value1,Symbol,Value2);
Console.WriteLine(calculation.Calculate());
