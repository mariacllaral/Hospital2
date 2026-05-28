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
                        
                        break;

                    case "3":

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
        static void adicionarPaciente(Paciente[] fila, Paciente p)
        {
            int i = 0;

            while (i < fila.Length && fila[i] != null)
            {
                i++;
            }

            if (i >= fila.Length)
            {
                Console.WriteLine("Fila cheia!");
                return;
            }
            fila[i] = p;
            Console.WriteLine("Paciente adicionado à fila.");
        }

        /*static void listarPaciente(Paciente[] fila)
        {
            int i = 0;
            bool possuiPacientes = false;

            foreach (var pacienteAtual in fila)
            {
                // Só exibe se a posição do vetor não estiver vazia (null)
                if (pacienteAtual != null)
                {
                    Console.WriteLine($"Senha {i}: {pacienteAtual.mostraPaciente()}");
                    possuiPacientes = true;
                }
                i++;
            }

            if (!possuiPacientes)
            {
                Console.WriteLine("Não há nenhum paciente na fila no momento.");
            }
        }*/
    }
}


