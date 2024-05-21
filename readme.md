# 1. ¿String es un tipo por valor o un tipo por referencia?
En C#, string es un tipo por referencia. Aunque string tiene un comportamiento que parece de valor (porque es inmutable), internamente es un tipo de referencia. Esto significa que cuando asignas una variable de tipo string a otra, ambas variables apuntan a la misma instancia en la memoria. Si una variable cambia el contenido de la cadena, en realidad se crea una nueva cadena en la memoria, y la variable apunta a esta nueva cadena, dejando la original inalterada.

# 2. ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape en un string en C# permiten incluir caracteres especiales que de otro modo serían difíciles de insertar directamente. Lista de las secuencias de escape más comunes:

- \\ - Barra invertida
- \' - Comilla simple
- \" - Comilla doble
- \0 - Carácter nulo
- \a - Alerta (beep)
- \b - Retroceso
- \f - Avance de página
- \n - Nueva línea
- \r - Retorno de carro
- \t - Tabulación horizontal
- \v - Tab
### ulación vertical

- \uXXXX - Carácter Unicode (donde XXXX son cuatro dígitos hexadecimales)
- \xXX - Carácter Unicode (donde XX son uno o más dígitos hexadecimales)

# 3. ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
En C#, los caracteres @ y $ se utilizan para modificar el comportamiento de las cadenas de texto de las siguientes maneras:

## Carácter @
- El carácter @ antes de una cadena de texto convierte la cadena en un string literal verbatim. Esto significa que la cadena se interpreta tal como está, ignorando las secuencias de escape. Además, permite que las cadenas se extiendan en varias líneas y se utilicen comillas dobles dobles "" para insertar una comilla doble dentro de la cadena.

                                    string path = @"C:\Users\Nombre\Documentos";
                                    string multiLine = @"Esta es una línea
                                    y esta es otra línea.";
                                    string quote = @"Él dijo: ""Hola Mundo!""";

## Carácter $
- El carácter $ antes de una cadena de texto convierte la cadena en una cadena interpolada, lo que permite insertar expresiones dentro de la cadena que serán evaluadas y sus resultados serán incluidos en la cadena.

                                    int a = 5;
                                    int b = 10;
                                    string interpolated = $"El valor de a es {a} y el valor de b es {b}.";

## Combinación de @ y $
- Se puede combinar @ y $ para crear un string interpolado verbatim. Esto combina las ventajas de ambos modificadores, permitiendo cadenas de varias líneas con interpolación de valores.

                                    string nombre = "Juan";
                                    string multilineInterpolated = @$"Hola {nombre},
                                    Esta es una cadena de varias líneas
                                    con interpolación de valores.";

# Conversor de tipo
### ToString(): Convierte el objeto a su representación en cadena.

                                    int number = 123;
                                    string numberString = number.ToString(); // "123"
# Comparador de cadenas
### Compare(): Compara dos cadenas y devuelve un número entero que indica su relación de orden (negativo si la primera cadena es menor, positivo si es mayor, y cero si son iguales).

                                    int result = string.Compare("abc", "def"); // -1
                                    int result = string.Compare("abc", "abc"); // 0
### CompareTo(): Compara la instancia actual con otra cadena y devuelve un número entero que indica su relación de orden.

                                    string str1 = "abc";
                                    string str2 = "def";
                                    int result = str1.CompareTo(str2); // -1

                                    == y !=: Operadores de igualdad y desigualdad que comparan dos cadenas.

                                    bool areEqual = "abc" == "abc"; // true
                                    bool areNotEqual = "abc" != "def"; // true
# Mayúsculas y minúsculas
### ToUpper(): Convierte la cadena a mayúsculas.

                                    string upper = "hello".ToUpper(); // "HELLO"
### ToLower(): Convierte la cadena a minúsculas.

                                    string lower = "HELLO".ToLower(); // "hello"

# Acceso a los caracteres individuales
### SubString(): Extrae una subcadena de una cadena dada una posición inicial y, opcionalmente, una longitud.

                                    string sub = "hello".Substring(1, 3); // "ell"
### Replace(): Reemplaza todas las ocurrencias de un carácter o cadena por otro carácter o cadena.

                                    string replaced = "hello".Replace('l', 'p'); // "heppo"
### Split(): Divide una cadena en un arreglo de subcadenas utilizando uno o más delimitadores.

                                    string[] parts = "a,b,c".Split(','); // ["a", "b", "c"]
### Trim(): Elimina los caracteres de espacio en blanco al principio y al final de la cadena.

                                    string trimmed = "  hello  ".Trim(); // "hello"
# Búsqueda y manipulación de una cadena
### IndexOf(): Devuelve el índice de la primera aparición de un carácter o cadena dentro de otra cadena.

                                    int index = "hello".IndexOf('e'); // 1
### LastIndexOf(): Devuelve el índice de la última aparición de un carácter o cadena dentro de otra cadena.

                                    int lastIndex = "hello".LastIndexOf('l'); // 3
### StartsWith(): Determina si una cadena comienza con una subcadena específica.

                                    bool starts = "hello".StartsWith("he"); // true
### EndsWith(): Determina si una cadena termina con una subcadena específica.

                                    bool ends = "hello".EndsWith("lo"); // true

# Funcionamiento de las expresiones regulares:
- Las expresiones regulares permiten realizar búsquedas y manipulaciones de texto avanzadas, como encontrar patrones específicos, validar formatos de entrada, extraer información de texto, reemplazar partes de un texto, etc.
- Funcionan mediante la definición de un patrón de búsqueda que consiste en caracteres literales y metacaracteres que representan clases de caracteres, cuantificadores, anclas, etc.
- Se aplican sobre una cadena de texto y se evalúan de izquierda a derecha para encontrar coincidencias con el patrón especificado.
# Aplicación de expresiones regulares:
- Validación de Entrada: Puedes usar expresiones regulares para validar formatos de entrada, como direcciones de correo electrónico, números de teléfono, códigos postales, etc.
- Extracción de Información: Son útiles para extraer información específica de cadenas de texto complejas, como números, fechas, nombres, etc.
- Manipulación de Texto: Las expresiones regulares te permiten realizar búsquedas y reemplazos avanzados en el texto, como eliminar espacios en blanco, cambiar el formato de fechas, normalizar datos, etc.
# Uso en C#:
Las expresiones regulares no son exclusivas de C#; son una característica estándar que está disponible en muchos lenguajes de programación y herramientas de manipulación de texto. En C#, puedes hacer uso de las expresiones regulares a través del espacio de nombres System.Text.RegularExpressions.