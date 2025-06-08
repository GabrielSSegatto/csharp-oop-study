using System.Collections.Generic;
using System;
using System.Globalization;
using employes_slary;


Console.WriteLine("Quantos empregados serão registrados?");
int quantiadeEmpregados = int.Parse(Console.ReadLine());

List<Funcionario> funcionarios = new List<Funcionario>();

for (int i = 0; i < quantiadeEmpregados; i++)
{
    CadastrarFuncionario(funcionarios);
    // Chama a função CadastrarFuncionario para cada funcionário
    // O usuário será solicitado a inserir os dados do funcionário
}


bool Continuar = true;
// Variável para controlar o loop principal
// O loop continuará até que o usuário decida sair
while (Continuar)
{
    // O código abaixo permite que o usuário realize operações com os funcionários cadastrados
    Console.WriteLine("Deseja realizar qual operação?");
    Console.WriteLine("1 - Aumentar salário");
    Console.WriteLine("2 - Diminuir salário");
    Console.WriteLine("3 - Cadastrar novo funcionário");
    Console.WriteLine("4 - Ver funcionarios cadastrados");
    Console.WriteLine("5 - Editar funcionário");
    Console.WriteLine("6 - Sair");

    int operacao = int.Parse(Console.ReadLine());
    switch (operacao)
    {
        case 1:
            Console.Clear();
            // Limpa a tela para melhor visualização
            MostrarFuncionarios(funcionarios);

            Console.Write("Digite o id do funcionário para aumentar o salário: ");
            int idAumento = int.Parse(Console.ReadLine());
            int posicaoAumento = funcionarios.FindIndex(f => f.Id == idAumento);
            // Quando o id não for encontrado, posicaoAumento será -1 por padrão
            if (posicaoAumento != -1)
            {
                Console.Write("Digite o percentual de aumento: ");
                decimal percentualAumento = decimal.Parse(Console.ReadLine());
                funcionarios[posicaoAumento].AumentarSalario(percentualAumento);
                Console.WriteLine($"Salário atualizado: {funcionarios[posicaoAumento].Salario:F2}");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            // Exibe a lista de funcionários após o aumento
            Console.WriteLine("Funcionários após o aumento:");
            MostrarFuncionarios(funcionarios);
            Console.WriteLine(); 
            break;
        case 2:
            Console.Clear();
            // Limpa a tela para melhor visualização
            MostrarFuncionarios(funcionarios);

            Console.Write("Digite o id do funcionário para diminuir o salário: ");
            int idDiminui = int.Parse(Console.ReadLine());
            int posicaoDiminui = funcionarios.FindIndex(f => f.Id == idDiminui);
            // Quando o id não for encontrado, posicaoDiminui será -1 por padrão
            if (posicaoDiminui != -1)
            {
                Console.Write("Digite o percentual de diminuição: ");
                decimal percentualDiminui = decimal.Parse(Console.ReadLine());
                funcionarios[posicaoDiminui].DiminuirSalario(percentualDiminui);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            // Exibe a lista de funcionários após a diminuição
            Console.WriteLine("Funcionários após a diminuição:");
            MostrarFuncionarios(funcionarios);
            Console.WriteLine(); 
            break;
        case 3:
            Console.Clear();
            // Limpa a tela para melhor visualização
            CadastrarFuncionario(funcionarios);
            break;
        case 4:
            Console.Clear();
            // Limpa a tela para melhor visualização
            MostrarFuncionarios(funcionarios);
            break;
        case 5:
            Console.Clear();
            // Limpa a tela para melhor visualização
            MostrarFuncionarios(funcionarios);

            Console.Write("Digite o id do funcionário para editar: ");
            int idEditar = int.Parse(Console.ReadLine());
            int posicaoEditar = funcionarios.FindIndex(f => f.Id == idEditar);
            // Quando o id não for encontrado, posicaoEditar será -1 por padrão
            if (posicaoEditar != -1)
            {
                Console.Write("Novo nome: ");
                string novoNome = Console.ReadLine();
                Console.Write("Novo salário: ");
                decimal novoSalario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios[posicaoEditar].Nome = novoNome;
                funcionarios[posicaoEditar].Salario = novoSalario;

                Console.WriteLine("Funcionário editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            // Exibe a lista de funcionários após a edição
            MostrarFuncionarios(funcionarios);
            Console.WriteLine(); 
            break;
        case 6:
            Console.Clear();
            // Limpa a tela para melhor visualização
            Console.WriteLine("Saindo do programa...");
            Continuar = false; // Define Continuar como false para sair do loop
            Console.WriteLine("Programa encerrado.");
            break;

        // Caso o usuário insira uma opção inválida
        // O loop continuará até que uma opção válida seja inserida
        default:
            Console.Clear();
            // Limpa a tela para melhor visualização
            bool operacaoValida = false;
            // Loop para garantir que a operação seja válida
            while (!operacaoValida)
            {
                Console.WriteLine("Operação inválida. Por favor, tente novamente.");
                Console.WriteLine("Deseja realizar qual operação?");
                Console.WriteLine("1 - Aumentar salário");
                Console.WriteLine("2 - Diminuir salário");
                Console.WriteLine("3 - Cadastrar novo funcionário");
                Console.WriteLine("4 - Ver funcionarios cadastrados");
                Console.WriteLine("5 - Sair");

                operacao = int.Parse(Console.ReadLine());
                if (operacao >= 1 && operacao <= 5)
                {
                    operacaoValida = true;
                }
            }
            break;

    }
}
static void CadastrarFuncionario(List<Funcionario> funcionarios)
{
    //verifica quanos funcionarios já estão cadastrados
    int EmpregadosExistentes = funcionarios.Count;


    Console.WriteLine($"Funcionario #{EmpregadosExistentes + 1}:");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    // Verifica se o id já existe
    bool idExiste = funcionarios.Exists(f => f.Id == id);
    while (idExiste)
    {
        Console.WriteLine("Id já existe. Por favor, insira um id único.");
        Console.Write("Id: ");
        id = int.Parse(Console.ReadLine());
        idExiste = funcionarios.Exists(f => f.Id == id);
    }

    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    funcionarios.Add(new Funcionario(id, nome, salario));
    Console.WriteLine("Funcionário cadastrado com sucesso!");
    Console.WriteLine(); 
}
static void MostrarFuncionarios(List<Funcionario> funcionarios)
{
    Console.WriteLine("Funcionários cadastrados:");
    foreach (Funcionario funcionario in funcionarios)
    {
        Console.WriteLine(funcionario);
    }
    Console.WriteLine(); // Adiciona uma linha em branco para melhor legibilidade
}