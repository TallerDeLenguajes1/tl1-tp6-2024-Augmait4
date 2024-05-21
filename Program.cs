// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;
holaMundo();
revertir();
calculadora();
cadenaDeTexto();
web();
Email();
static void holaMundo(){
    Console.WriteLine("Hello, World!");
 int a;
 int b;
 a=10;
 b=a;
 Console.WriteLine("valor de a:"+a);
 Console.WriteLine("valor de b:"+b);
}
static void revertir(){
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
}
 static void calculadora(){
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
             Console.WriteLine("La Suma de "+ X.ToString() +" + " + Y.ToString() +" es :" + Sumas.ToString());
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
             Console.WriteLine("La resta de "+ X.ToString() +" - " + Y.ToString() + " es: "+ resta.ToString());
         }else
         {
             resta = Y - X;
             Console.WriteLine("La resta de "+ Y.ToString() +" - " + X.ToString() + " es: "+ resta.ToString());
         }
         break;
         case 3:
             Console.WriteLine("Ingresar Numeros: ");
             Console.WriteLine("X: ");
             X = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Y: ");
             Y = Convert.ToInt32(Console.ReadLine());
             float Multiplicar = X * Y;
             Console.WriteLine("El Producto de "+ X.ToString() +" * " + Y.ToString() +" es :"+ Multiplicar.ToString());
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
             Console.WriteLine("La divicion de "+ Convert.ToString(X) +" / " + Convert.ToString(Y) + " es: "+ Convert.ToString(dividir));   
             }
             else{
             Console.WriteLine("La divicion en 0 es Imposible");
             }
         }else
         {
             if (X != 0)
             {
             dividir = Y / X;
             Console.WriteLine("La divicion de "+ Y.ToString() +" / " + X.ToString() + " es: "+ dividir.ToString());   
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
                 Console.WriteLine("El valor absoluto de "+ X.ToString() +" es :"+ Xabs.ToString());  
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
                 Console.WriteLine("El Cuadrado de "+ X.ToString() +" es : "+ Xcuad.ToString());  
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
                 Console.WriteLine("La raiz Cuadrada de "+ X.ToString() +" es : "+ Xraiz.ToString());  
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
                 Console.WriteLine("El Seno de "+ X.ToString() +" es : "+ Xsen.ToString());  
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
                 Console.WriteLine("El Coseno de "+ X.ToString() +" es : "+ Xcos.ToString());  
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
                 Console.WriteLine("El Seno de "+ X.ToString() +" es : "+ Xent.ToString());  
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
                         Console.WriteLine("El numero mayor entre ("+X.ToString()+","+Y.ToString()+") es: "+ mayor.ToString());
                     }else{
                         mayor = Y;
                         Console.WriteLine("El numero mayor entre ("+X.ToString()+","+Y.ToString()+") es: "+ mayor.ToString());
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
 }
static void cadenaDeTexto(){
    Console.WriteLine("Ingresar Una Frase:");
    string cadena = Console.ReadLine();
    int longCad = Convert.ToInt32(Strings.Len(cadena));
    Console.WriteLine($"La longitud de la Cadena es : {longCad}");
    Console.WriteLine("Ingresar Una Segunda Frase:");
    string cadena2 = Console.ReadLine();
    string concat = String.Concat(cadena,cadena2);
    Console.WriteLine($"La palabra Concatenada es: {concat}");
    string subCad = concat.Substring(3,5);
    Console.WriteLine($"La subCadena es : {subCad}");
    calculadora();
    foreach (char item in concat)
    {
        Console.WriteLine(item);
    }
    int index = 0;
    int count = 0;
    Console.WriteLine("Ingresar Una Palabra a Buscar en la frase Principal:");
    string palabra = Console.ReadLine();
            while ((index = cadena.IndexOf(palabra, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            Console.WriteLine($"Ocurrencia encontrada en el índice: {index}");
            index += palabra.Length; // Avanzar el índice para seguir buscando
        }

        if (count == 0)
        {
            Console.WriteLine("La palabra no fue encontrada en la cadena.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' aparece {count} veces en la cadena.");
        }
    cadena = cadena.ToUpper();
    Console.WriteLine($"La Cadena Principal en mayuscula es : {cadena}");
    cadena = cadena.ToLower();
    Console.WriteLine($"La Cadena Principal en mayuscula es : {cadena}");
    string[] cadenaprueba = "ea,ae,auch".Split(',');
    foreach (string item in cadenaprueba)
    {
        Console.WriteLine(item);
    }
    float pruebaString = 0;
    Console.WriteLine("Ingrese una ecuacion simple (x+y, x-y, x*y, x/y): ");
    string ecuacion = Console.ReadLine();
    string[] ecuaciones;
    if (ecuacion.IndexOf('+') > 0)
    {
        ecuaciones = ecuacion.Split('+');
        foreach (string item in ecuaciones)
        {
            pruebaString = pruebaString + Convert.ToInt32(item);
            
        }
        Console.WriteLine(pruebaString);
    }else if (ecuacion.IndexOf('-') > 0)
    {
        ecuaciones = ecuacion.Split('-');
        foreach (string item in ecuaciones)
        {
            pruebaString = pruebaString - Convert.ToInt32(item);
        }
        Console.WriteLine(pruebaString);
    }else if (ecuacion.IndexOf('*') > 0)
    {
        ecuaciones = ecuacion.Split('*');
        float pruebaString2 = Convert.ToInt32(ecuaciones[0]) * Convert.ToInt32(ecuaciones[1]);
        Console.WriteLine(pruebaString2);
    }else if (ecuacion.IndexOf('/') > 0){
        ecuaciones = ecuacion.Split('/');
        float pruebaString2 = Convert.ToInt32(ecuaciones[0]) / Convert.ToInt32(ecuaciones[1]);
        Console.WriteLine(pruebaString2);
    }
}
static void web()
    {
        // Solicitar al usuario que ingrese una cadena
        Console.Write("Ingrese una cadena para verificar si es una dirección web (URL): ");
        string cadena = Console.ReadLine();

        // Definir el patrón de expresión regular para una URL
        string patronURL = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";

        // Verificar si la cadena coincide con el patrón de URL
        if (Regex.IsMatch(cadena, patronURL))
        {
            Console.WriteLine("La cadena ingresada es una dirección web (URL) válida.");
        }
        else
        {
            Console.WriteLine("La cadena ingresada NO es una dirección web (URL) válida.");
        }
    }
static void Email()
    {
        // Solicitar al usuario que ingrese una cadena
        Console.Write("Ingrese una cadena para verificar si es una dirección de correo electrónico válida: ");
        string cadena = Console.ReadLine();

        // Definir el patrón de expresión regular para una dirección de correo electrónico
        string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Verificar si la cadena coincide con el patrón de correo electrónico
        if (Regex.IsMatch(cadena, patronEmail))
        {
            Console.WriteLine("La cadena ingresada es una dirección de correo electrónico válida.");
        }
        else
        {
            Console.WriteLine("La cadena ingresada NO es una dirección de correo electrónico válida.");
        }
    }