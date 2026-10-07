using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;

// ARRAYLISTS

ArrayList arrayList = new ArrayList();

// Adicionando item à lista
arrayList.Add(5);

// Adicionando vários itens à lista
arrayList.AddRange(new int[] { 1, 2, 3 });

// Adicionando 7.8 à lista
arrayList.Add(7.8);

// Percorrendo os itens da lista
Console.WriteLine("Itens da ArrayList:");

foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}

Console.WriteLine();

// LISTAS GENÉRICAS

List<double> numbers = new List<double>();

Console.WriteLine("Digite 'sair' para encerrar.");

bool run = true;

do
{
    Console.WriteLine("Digite um número:");

    string numberStr = Console.ReadLine();

    if (numberStr.Equals("sair", StringComparison.OrdinalIgnoreCase))
    {
        run = false;
        Console.WriteLine("Processo encerrado.");
    }
    else
    {
        // Verifica se o usuário digitou um número
        if (!double.TryParse(
            numberStr,
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out double number))
        {
            Console.WriteLine("Você não digitou um número.");
            continue;
        }

        // Adiciona o número à lista
        numbers.Add(number);

        // Calcula e mostra a média
        Console.WriteLine(
            "A média dos valores informados é: " + numbers.Average()
        );
    }

} while (run);

// LISTAS DE TIPOS ABSTRATOS DE DADOS (TAD)

List <Person> people = new list<Person>();

//criar uma variavel do tipo person
Person p1 = new Person();
p1.Name = "Joao";
p1.age = 42;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

// adicionando á lista inline
people.Add(new Person {
    Name = "Mary",
    Age = 39,
    Nationality = CountryEnum.US
});
people.Add(new Person {
    Name = "Carlitos",
    Age = 39,
    Nationality = CountryEnum.AR
});
people.Add(new Person {
    Name = "Juanito",
    Age = 39,
    Nationality = CountryEnum.PY
});

//exemplo de ordenação de lista generica utilizando LINQ
List<Person>results = people.OrderBy( p => p.Name).ToList();

//percorremos a lista
foreach(Person p in results)
{
    Console.WriteLine(
        $"Nome: {p.Name}, Idade: {p.Age}, Nac: {p.Nationality}"
    );
}