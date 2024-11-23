// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/
//metodos que devuelven valor booleano

/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "the quick roem fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
*/
//negacion lógica
/*
string pangram = "the quick roem fox jumps over the lazy dog.";

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/
//desigualdad

/*
int a = 7;
int b = 6;
Console.WriteLine(a != b);
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);
*/

// operador condicional ternario

/*
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Random random = new Random();
int valor = random.Next(0, 2);
Console.WriteLine((valor != 1) ? "head" : "tails");
*/

/*
string permission = "dfs";
int level = 55;

if(permission.Contains("Admin"))
{
    if (level > 55){
        Console.WriteLine("Welcome, super admin user.");
    }
    else
    {
        Console.WriteLine("Welcome User admin");

    }
}

else if(permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contac an admin for acces");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
} 
else
{
    Console.WriteLine("You do not have sufficent privileges");
}

*/

//VARIABLE DENTRO DE UN BLOQUE DE CÓDIGO
/*
bool flag = true;
int value;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/
/*
int value;

if(true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

*/

//bloque de codigo sin llves
/*
bool flag = true;
if (flag)
    Console.WriteLine(flag);

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found bOB");
else if (name == "steve")
    Console.WriteLine("Found steve");
else 
    Console.WriteLine("Found Chuck");
*/
//Ejemplo de bloque de código sin llaves
int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = true;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        if (found)
        {
            Console.WriteLine("Set contains 42");
        }
        Console.WriteLine($"Total: {total}");
    }


}





