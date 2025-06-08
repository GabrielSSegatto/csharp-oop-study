using System.Collections.Generic;


//inicialização de uma lista de strings
List<string> Nomes = new List<string>();

Nomes.Add("Maria");
Nomes.Add("Alex");
Nomes.Add("Bob");
Nomes.Add("Anna");

Nomes.Insert(2, "Marco"); //insere o nome Marco na posição 2

// Percorre a lista e imprime os nomes
foreach (string nome in Nomes)
{
    Console.WriteLine(nome);
}

//Contagem de elementoos da lista
Console.WriteLine("Contagem : " + Nomes.Count);


// Uso do find para encontrar o primeiro nome que começa com "A"

//string s1 = Nomes.Find(x => x.StartsWith("A"));
//Console.WriteLine("Primeiro nome que começa com 'A': " + s1);

//A função StartsWith é interna do C#, e é mais segura, pois n dará erro se a string estiver vazia ou nula.
// Alternativa usando o índice do primeiro caractere
//Dentro do find, é passado uma expressão lambda, predicado, que verifica se o primeiro caractere é 'A'
string s1 = Nomes.Find(x => x[0] == 'A');
Console.WriteLine("Primeiro nome que começa com 'A': " + s1);


//string s2 = Nomes.Find(x => x.EndsWith("A"));
string s2 = Nomes.FindLast(x => x[0] == 'A');
Console.WriteLine("Último nome que começa com 'A': " + s2);

// Uso do FindIndex para encontrar o índice do primeiro e último nome que começa com "A"
int pos1 = Nomes.FindIndex(x => x[0] == 'A');
Console.WriteLine("Posição do primeiro nome que começa com 'A': " + pos1);

int pos2 = Nomes.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Posição do último nome que começa com 'A': " + pos2);

//filtrar lista para nomes com 5 caracteres
List<string> NomesFiltrada = Nomes.FindAll(x => x.Length == 5);
Console.WriteLine("======================"); //separador pra organização
Console.WriteLine("Nomes com 5 caracteres:");
foreach (string nome in NomesFiltrada)
{
    Console.WriteLine(nome);
}

//Remover um nome da lista
Nomes.Remove("Alex");
Console.WriteLine("======================"); //separador pra organização
Console.WriteLine("Nomes após remoção de 'Alex':");
foreach (string nome in Nomes)
{
    Console.WriteLine(nome);
}
// Se dar um Nomes.Remove("Alex"); novamente, ou Nomes.Remove("aUDSAHodu"); não dará erro, pois o método Remove não lança exceção se o elemento não for encontrado, apenas não faz nada.

//Remover todos os nomes que começam com 'M'
Nomes.RemoveAll(x => x[0] == 'M');
Console.WriteLine("======================"); //separador pra organização
Console.WriteLine("Nomes após remoção de nomes que começam com 'M':");
foreach (string nome in Nomes)
{
    Console.WriteLine(nome);
}

Nomes.RemoveAt(0); //Remove o primeiro elemento da lista
Console.WriteLine("======================"); //separador pra organização
Console.WriteLine("Nomes após remoção do primeiro elemento:");
foreach (string nome in Nomes)
{
    Console.WriteLine(nome);
}

//Nomes.RemoveRange(2, 2);
//Apartir da posição 2, remove 2 elementos, está comentado pq não existe mais nenhum elemento na segunda posição dessa lista 
