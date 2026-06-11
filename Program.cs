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
                        listarPacientes(fila);
                        Console.ReadKey();
                        Console.Clear();
                        break;
 
                    case "3":
                        atenderPaciente(fila);
                        Console.ReadKey();
                        Console.Clear();
                        break;
 
                    case "Q":
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                        break;
 
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
 
        static void adicionarPaciente(Paciente[] fila, Paciente p)
        {
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
 
            if (p.preferencial.ToUpper() == "SIM")
            {
                int posicaoInsercao = 0;
 
                while (posicaoInsercao < totalPacientes &&
                       fila[posicaoInsercao].preferencial.ToUpper() == "SIM")
                {
                    posicaoInsercao++;
                }
 
                for (int j = totalPacientes; j > posicaoInsercao; j--)
                {
                    fila[j] = fila[j - 1];
                }
 
                fila[posicaoInsercao] = p;
            }
            else
            {
                fila[totalPacientes] = p;
            }
 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPaciente " + p.nome + " adicionado à fila com sucesso!");
            Console.ResetColor();
        }
 
        static void listarPacientes(Paciente[] fila)
        {
            int total = contarPacientes(fila);
 
            if (total == 0)
            {
                Console.WriteLine("Não há pacientes na fila.");
                return;
            }
 
            Console.WriteLine("=== LISTA DE PACIENTES (" + total + " na fila) ===");
            Console.WriteLine();
 
            for (int i = 0; i < fila.Length; i++)
            {
                if (fila[i] != null)
                {
                    if (fila[i].preferencial.ToUpper() == "SIM")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("--- Paciente " + (i + 1) + " [PREFERENCIAL] ---");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("--- Paciente " + (i + 1) + " ---");
                    }
                    fila[i].mostraPaciente();
                    Console.WriteLine();
                }
            }
        }
 
        static void atenderPaciente(Paciente[] fila)
        {
            int total = contarPacientes(fila);
 
            if (total == 0)
            {
                Console.WriteLine("Não há pacientes na fila para atender.");
                return;
            }
 
            for (int i = 0; i < fila.Length; i++)
            {
                if (fila[i] != null)
                {
                    if (fila[i].preferencial.ToUpper() == "SIM")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== ATENDENDO PACIENTE PREFERENCIAL ===");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== ATENDENDO PRÓXIMO PACIENTE ===");
                        Console.ResetColor();
                    }
 
                    fila[i].mostraPaciente();
                    fila[i] = null;
                    Console.WriteLine();
                    Console.WriteLine("Paciente atendido e removido da fila.");
                    Console.WriteLine("Pacientes restantes na fila: " + contarPacientes(fila));
                    return;
                }
            }
        }
 
        static int contarPacientes(Paciente[] fila)
        {
            int total = 0;
            for (int i = 0; i < fila.Length; i++)
            {
                if (fila[i] != null)
                    total++;
            }
            return total;
        }
    }
}
