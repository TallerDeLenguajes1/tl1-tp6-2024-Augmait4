// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;
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
    int salir = 1;
while (opcions == 1)
{
    Console.WriteLine("----MENU----");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Valor Absoluto");
    Console.WriteLine("6- Cuadrado");
    Console.WriteLine("7- Raiz");
    Console.WriteLine("8- Seno");
    Console.WriteLine("9- Coseno");
    Console.WriteLine("10- Parte entera de un numero real");
    Console.WriteLine("11- Maximo Y Minimo entre 2 numeros");
    Console.WriteLine("12- Salir");
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
        case 5:
            Console.WriteLine("Ingresar Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                float Xabs = Math.Abs(X); 
                Console.WriteLine("El valor absoluto de "+ X +" es :"+ Xabs);  
            }else
            {
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 6:
            Console.WriteLine("Ingresar Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                double Xcuad = Math.Pow(X,2); 
                Console.WriteLine("El Cuadrado de "+ X +" es : "+ Xcuad);  
            }else
            {
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 7:
            Console.WriteLine("Ingresar Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                double Xraiz = Math.Sqrt(X); 
                Console.WriteLine("La raiz Cuadrada de "+ X +" es : "+ Xraiz);  
            }else
            {
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 8:
            Console.WriteLine("Ingresar Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                double Xsen = Math.Sin(X); 
                Console.WriteLine("El Seno de "+ X +" es : "+ Xsen);  
            }else
            {
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 9:
            Console.WriteLine("Ingresar Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                double Xcos = Math.Cos(X); 
                Console.WriteLine("El Coseno de "+ X +" es : "+ Xcos);  
            }else
            {
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 10:
            Console.WriteLine("Ingresar Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                int Xent = Convert.ToInt32(X);
                Console.WriteLine("El Seno de "+ X +" es : "+ Xent);  
            }else{
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 11:
            float mayor = 0;
            Console.WriteLine("Ingresar Primer Numero: ");
            if (float.TryParse(Console.ReadLine(),out X))
            {
                Console.WriteLine("Ingresar segundo Numero: ");
                if(float.TryParse(Console.ReadLine(),out Y)){
                    if (X > Y){
                        mayor = X;
                        Console.WriteLine("El numero mayor entre ("+X+","+Y+") es: "+ mayor);
                    }else{
                        mayor = Y;
                        Console.WriteLine("El numero mayor entre ("+X+","+Y+") es: "+ mayor);
                    }
                }else
                {
                    Console.WriteLine("Lo ingresado no es una Entrada Valida");
                }
            }else{
                Console.WriteLine("Lo ingresado no es una Entrada Valida");
            }
        break;
        case 12:
        salir = 0;
        opcions = 0;
        break;
    }
    if (salir == 1)
    {
    Console.WriteLine("Desea hacer otra operacion? (1: Si / 0 : NO)");
    opcions = Convert.ToInt32(Console.ReadLine());
    }
}