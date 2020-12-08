using System;
using AulaPOO_Herenca.classes;

namespace AulaPOO_Herenca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaFisica pessoaFisica = new PessoaFisica();

            pf.nome = "Danilo";
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();

            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
        }
    }
}
