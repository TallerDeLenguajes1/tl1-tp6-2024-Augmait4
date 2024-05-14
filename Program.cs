// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("Ingresar el numero que desea invertir: ");
int i;
string suma = "";
int dig;
string s = Console.ReadLine();
if (int.TryParse(s, out i))
{
    if (i >= 0)
    {
        while (i>0)
        {
            dig = i % 10;
            suma = suma + Convert.ToString(dig);
            i = i/10;        
            }
            Console.WriteLine(suma);
    }
}