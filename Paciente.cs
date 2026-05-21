using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente
    {
        public string nome;
        public int idade;
        public string sintoma;
        public string telefone;
        public bool preferencial;

        public void cadastrarPaciente()
        {
            Console.WriteLine("Digite seu nome:");
            this.nome = Console.ReadLine();
            while (this.nome == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Informação Inválida digite novamente\n");
                Console.ResetColor();
                Console.WriteLine("Digite seu nome:");
                this.nome = Console.ReadLine();
            }

            Console.WriteLine("Digite sua Idade:");
            string inputIdade = Console.ReadLine();
            while (!int.TryParse(inputIdade, out this.idade))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Informação Inválida digite novamente\n");
                Console.ResetColor();
                Console.WriteLine("Digite sua Idade");
                inputIdade = Console.ReadLine();
                int.TryParse(inputIdade, out this.idade);
            }

            Console.WriteLine("Paciente preferencial? (s/n):");
            string resp = Console.ReadLine().ToLower();

            this.preferencial = resp == "s";

            Console.WriteLine("Telefone com DDD(apenas numeros):");
            Console.WriteLine("EX:11970707070");
            string tel = Console.ReadLine();
            while (tel.Length != 11)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Informação Inválida digite novamente\n");
                Console.ResetColor();
                Console.WriteLine("Telefone com DDD(apenas numeros):");
                Console.WriteLine("EX:11970707070");
                tel = Console.ReadLine();
            }
            if (tel.Length == 11)
            {
                this.telefone = tel.Insert(0, "(").Insert(3, ")").Insert(9, "-");
            }

            Console.WriteLine("Quais sintomas o paciente apresenta!");
            this.sintoma = Console.ReadLine();
            while (this.sintoma == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Informação Inválida digite novamente\n");
                Console.ResetColor();
                Console.WriteLine("Digite seu nome:");
                this.sintoma = Console.ReadLine();
            }

         
        }
       // public virtual void mostraDados()
      //  {
       //     Console.WriteLine("Seus dados:\n");
       //     Console.WriteLine("Nome: {0}\nIdade: {1}\nPrefencial: {2}\nTelefone: {3}\nSintoma: {4}", this.nome, this.idade,this.preferencial, this.telefone, this.sintoma);
       // }
    }

}

