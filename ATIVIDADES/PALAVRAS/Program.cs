string firstName = "Joao";
string lastName = "Epeling";

string note = lastName.ToUpper()
                 + " " +  firstName;

string initials = lastName[0] + " " + firstName[0];      


Console.WriteLine ("" + initials);

// F ormatação de String
string texto = string.Format (
    "{0} {1} nascido em {2}",
    firstName, 
    lastName,
    "2007"
);

Console.WriteLine (texto);

// C# é uma linguagem filga do C++
// Totalmente orientada a Objetos
// Portanto, tudo dentro do C é descendente 
// do tipo Object

int age = 19;
object ageBoxing = age;
int ageUnboxing = (int) ageBoxing;

/*
VETORES UNI-DIMENSIONAIS
Sintaxe: type [] name;
*/

// Declarção sem inicialização
// Obs.: Variável alocada mas nula

int [] numbers;


// Inicializando o vetor
numbers = new int [5];

// Atribuindo valores ao vetor
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

// É possível declarar o vetor
//  e ja definir e atribuir

int [] number2 =
 new int[] {100, 200, 300 };

int[] number3 = 
{1000, 2000, 3000, 4000 };


// Percorrendo um vetor e adicionando
// valores dinamicamente

Console.WriteLine("Iniciando com vetores");

Console.WriteLine("Informe o tamanho do vetor:");

int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = new int[size];
int total = 0; //acumulator
int counter = 0;

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(
        "Digíte para [" + i + "]: "
);
myArray[i] = Convert.ToInt32(
    Console.ReadLine()
);

total += myArray[i];
counter++;
}

Console.WriteLine("Contagem = " + counter );
Console.WriteLine("Total = " + total );


/* Exemplo dos nomes dos meses do ano */

string[] months = new string [12];
for(int i =1; i <= 12; i++);
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
DateTime lastDayMonthBefore =
    firstDay.AddDays(-1);

    string monthName = firstDay.ToString("MMMM", Syestem.Globalization.CultureInfo.CreateSpecificCulture("pt-BR"));

    months[i - 1] = monthName;

 }

 foreach (string monthName in months)
 {
    Console.WriteLine($"---> {monthName}");

 }