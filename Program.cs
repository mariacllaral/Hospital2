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
            Paciente p = new Paciente();

            while (op.ToUpper() != "q")
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
                        p.cadastrarPaciente();
                        Console.Clear();
                        break;

                    case "2":
                        p.mostraDados();
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
    }
}


