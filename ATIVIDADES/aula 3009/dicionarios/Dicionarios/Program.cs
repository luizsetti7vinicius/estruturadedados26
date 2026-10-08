using System;
using System.Collections;
using System.Collections.Generic;


Hashtable phoneBook = new Hashtable()
{
    { "Edson Arantes do Nascimento", "0000" },
    { "Ronaldo Nazario dos Santos", "1111" },
    { "Flavio Bolsonaro", "2222" }
};

// Adicionando em tempo de execução
phoneBook["Acelino Popo de Freitas"] = "33333";

// Tratando possível erro de duplicidade de chave
try
{
    phoneBook.Add("Edson Arantes do Nascimento", "000000");
}
catch (ArgumentException ae)
{
    Console.WriteLine("Chave ja existente. " + ae.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Erro imprevisto. " + ex.Message);
}

// ========================================
// PERCORRENDO A TABELA HASH
// ========================================

Console.WriteLine();
Console.WriteLine("Caderninho de Telefone");

if (phoneBook.Count == 0)
{
    Console.WriteLine("Agenda vazia.");
}
else
{
    int i = 1;

    foreach (DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{i}. {entry.Key} - {entry.Value}");
        i++;
    }
}

// ========================================
// BUSCA POR CHAVE
// ========================================

Console.WriteLine();
Console.WriteLine("Busca por nome:");

string? name = Console.ReadLine();

if (!string.IsNullOrEmpty(name) && phoneBook.Contains(name))
{
    string number = (string)phoneBook[name]!;
    Console.WriteLine(name + " - " + number);
}
else
{
    Console.WriteLine($"{name} não encontrada.");
}

// ========================================
// DICIONÁRIO
// ========================================

Dictionary<string, string> dic = new Dictionary<string, string>()
{
    { "Dom Pedrão II", "123456" },
    { "Joaquim José da Silva Xavier", "112233" }
};

// Obtendo valor do dicionário
string value = dic["Dom Pedrão II"];

Console.WriteLine();
Console.WriteLine("Valor de Dom Pedrão II: " + value);

// Alterando valor
dic["Dom Pedrão II"] = "666";

// Percorrendo o dicionário
foreach (KeyValuePair<string, string> pair in dic)
{
    Console.WriteLine(pair.Key + " - " + pair.Value);
}
