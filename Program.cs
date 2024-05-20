// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

// Console.WriteLine("Ingresar el numero que desea invertir: ");
// int i;
// string suma = "";
// int dig;
// string s = Console.ReadLine();
// if (int.TryParse(s, out i))
// {
//     if (i >= 0)
//     {
//         while (i>0)
//         {
//             dig = i % 10;
//             suma = suma + Convert.ToString(dig);
//             i = i/10;        
//             }
//             Console.WriteLine(suma);
//     }
// }
    Console.WriteLine("------CALCULADORA------");
    int opcions = 1;
while (opcions == 1)
{
    Console.WriteLine("----MENU----");
    Console.WriteLine("1- SUMAR");
    Console.WriteLine("2- RESTAR");
    Console.WriteLine("3- MULTIPLICAR");
    Console.WriteLine("4- DIVIDIR");
    Console.WriteLine("INGRESAR OPCION: ");
    int menu=Convert.ToInt32(Console.ReadLine());
    switch (menu)
    {
        case 1:
            Console.WriteLine("Ingresar Numeros: ");
            Console.WriteLine("X: ");
            float X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            float Y = Convert.ToInt32(Console.ReadLine());
            float Sumas = X + Y;
            Console.WriteLine("La Suma de "+ X +" + " + Y +" es :"+Sumas);
        break;
        case 2:
            float resta;
            Console.WriteLine("Ingresar Numeros: ");
            Console.WriteLine("X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Desea Restar X-Y (1) o Y-X (2)?:");
        int opcionResta = Convert.ToInt32(Console.ReadLine());
        if (opcionResta ==1)
        {
            resta = X - Y;
            Console.WriteLine("La resta de "+ X +" - " + Y + " es: "+ resta);
        }else
        {
            resta = Y - X;
            Console.WriteLine("La resta de "+ Y +" - " + X + " es: "+ resta);
        }
        break;
        case 3:
            Console.WriteLine("Ingresar Numeros: ");
            Console.WriteLine("X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
            float Multiplicar = X * Y;
            Console.WriteLine("El Producto de "+ X +" * " + Y +" es :"+ Multiplicar);
        break;
        case 4:
        float dividir;
        Console.WriteLine("Ingresar Numeros: ");
        Console.WriteLine("X: ");
        X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Y: ");
        Y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Desea hacer X/Y (1) o Y/X (2)?:");
        int opcionDividir = Convert.ToInt32(Console.ReadLine());
        if (opcionDividir ==1)
        {
            if (Y != 0)
            {
            dividir = X / Y;
            Console.WriteLine("La divicion de "+ X +" / " + Y + " es: "+ dividir);   
            }
            else{
            Console.WriteLine("La divicion en 0 es Imposible");
            }
        }else
        {
            if (X != 0)
            {
            dividir = Y / X;
            Console.WriteLine("La divicion de "+ Y +" / " + X + " es: "+ dividir);   
            }
            else{
            Console.WriteLine("La divicion en 0 es Imposible");
            }
        }
        break;
    }
    Console.WriteLine("Desea hacer otra operacion? (1: Si / 0 : NO)");
    opcions = Convert.ToInt32(Console.ReadLine());
}
