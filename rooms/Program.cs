//Descrição: Esse programa simula o alugel de 10 quartos de um hotel, númerados de 0 a 9, exibindo os quartos ocupados e dados dos hóspedes.

using rooms;

Console.WriteLine("Quantos quartos serão alugados?");
int quantidade = int.Parse(Console.ReadLine());

//Recebe dados e cria o quarto
Quarto[] quarto = new Quarto[10];

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"Aluguel #{i + 1}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int numeroQuarto = int.Parse(Console.ReadLine());

    //verifica se o quarto já está ocupado
    while (quarto[numeroQuarto] != null)
    {
        Console.WriteLine("Quarto já ocupado! Tente novamente.");
        Console.Write("Quarto: ");
        numeroQuarto = int.Parse(Console.ReadLine());
    }

    //Cria o quarto e atribui os dados do hóspede
    quarto[numeroQuarto] = new Quarto(nome, email);
}

//Exibe os quartos ocupados
Console.WriteLine("Quartos ocupados:");
for (int i = 0; i < 10; i++)
{
    if (quarto[i] != null)
    {
        Console.WriteLine($"{i}: {quarto[i]}");
    }
}