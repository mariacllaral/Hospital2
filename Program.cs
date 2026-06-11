using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string op = "";
            Paciente[] fila = new Paciente[100];
            // Loop principal do programa, exibindo o menu e processando as opções do usuário.
            while (op.ToUpper() != "Q")
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| Opção desejada                     |");
                Console.WriteLine("| Cadastrar Paciente -- 1            |");
                Console.WriteLine("| Listar Pacientes ---- 2            |");
                Console.WriteLine("| Atender Paciente ---- 3            |");
                Console.WriteLine("| Fechar -------------- Q            |");
                Console.WriteLine("--------------------------------------");
                Console.Write("| Digite o numero da opção: ");
                op = Console.ReadLine();
                Console.WriteLine("--------------------------------------");
                switch (op.ToUpper())
                {
                    case "1":
                        Paciente p = new Paciente();
                        p.cadastrarPaciente();
                        adicionarPaciente(fila, p);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        // Parte da Listagem
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        // Parte do Atendimento
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "Q":
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.Clear();
                        break;
                }
            }
        }
        // Método para adicionar um paciente à fila, considerando a prioridade dos pacientes preferenciais.
        static void adicionarPaciente(Paciente[] fila, Paciente p)
        {
            //Contar o número de pacientes atualmente na fila.
            int totalPacientes = 0;
            while (totalPacientes < fila.Length && fila[totalPacientes] != null)
            {
                totalPacientes++;
            }

            if (totalPacientes >= fila.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fila cheia!");
                Console.ResetColor();
                return;
            }
            //Verificar se o paciente é preferencial e inserir na posição correta.
            if (p.preferencial != null && p.preferencial.ToUpper() == "SIM")
            {
                int posicaoInsercao = 0;

                // Encontrar a posição correta para inserir o paciente preferencial, garantindo que ele fique à frente dos pacientes não preferenciais.
                while (posicaoInsercao < totalPacientes &&
                       fila[posicaoInsercao].preferencial != null &&
                       fila[posicaoInsercao].preferencial.ToUpper() == "SIM")
                {
                    posicaoInsercao++;
                }

                // Deslocar os pacientes não preferenciais para a direita para abrir espaço para o paciente preferencial.
                for (int j = totalPacientes; j > posicaoInsercao; j--)
                {
                    fila[j] = fila[j - 1];
                }
                // Inserir o paciente preferencial na posição correta.
                fila[posicaoInsercao] = p;
                }
            // se o paciente não for preferencial, ele é adicionado ao final da fila.
            else
            {

            }
                {
                    fila[totalPacientes] = p;
                }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nPaciente {p.nome} adicionado à fila com sucesso!");
            Console.ResetColor();
        }
    }
}


