using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {         
            Aluno[] VetorA = null;
            int op, n = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar alunos.");
                Console.WriteLine("2. Mostrar dados do aluno pela matricula.");
                Console.WriteLine("3. Mostrar o aluno com maior nota média.");
                Console.WriteLine("4. Sair.");
                Console.WriteLine("============================================");
                Console.Write("Sua opção: ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Digite uma opção válida!");
                    op = 0;
                    Console.ReadKey();
                }                
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Quantos alunos serão cadastrados?");
                        do
                        {
                            try
                            {
                                n = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Digite um número válido!");
                                n = 0;
                                Console.ReadKey();
                            }
                        }
                        while (n == 0);                       
                        VetorA = new Aluno[n];
                        for (int i = 0; i < n; i++)
                        {
                            VetorA[i] = new Aluno();
                            Console.Write("Matricula: ");
                            VetorA[i].Matricula = Console.ReadLine();
                            Console.Write("Nome: ");
                            VetorA[i].Nome = Console.ReadLine();
                            double[] aux = new double[4];
                            for (int j = 0; j < 4; j++)
                            {
                                Console.Write("Nota "+(j+1)+": ");
                                do
                                {
                                    try
                                    {
                                        aux[j] = double.Parse(Console.ReadLine());
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Digite uma nota válida!");
                                        aux[j] = -1;
                                        Console.ReadKey();
                                    }
                                } while (aux[j] == -1);
                                                               
                            }
                            VetorA[i].Vetornota = aux;
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        string pesquisa=null;
                        Console.Write("Matricula para pesquisa: ");
                        pesquisa = Console.ReadLine();
                        try
                        {
                            foreach (Aluno item in VetorA)
                            {
                                if (item.Matricula == pesquisa)
                                {
                                    Console.WriteLine("Nome: " + item.Nome);
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Console.WriteLine("Nota " + (i + 1) + ": " + item.Vetornota[i]);
                                    }
                                    Console.WriteLine("Média: " + item.media);
                                }
                                else
                                {
                                    Console.WriteLine("Matricula não encontrada!");
                                }
                                break;
                            }
                        }
                        catch(NullReferenceException)
                        {
                            Console.WriteLine("Nenhuma matricula cadastrada!");
                            pesquisa = null;
                            Console.ReadKey();
                        }
                        
                        Console.ReadKey();
                        break;
                    case 3:
                        double aux2 = 0;
                        int aux3 = 0, aux4 = 0;
                        try
                        {
                            foreach (Aluno item in VetorA)
                            {
                                if (item.media >= aux2)
                                {
                                    aux2 = item.media;
                                    aux4 = aux3;
                                }
                                aux3++;
                            }
                            Console.WriteLine("Aluno: " + VetorA[aux4].Nome + "\nMédia: " + VetorA[aux4].media);
                            Console.ReadKey();
                        }
                        catch(NullReferenceException)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado!");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;

                }
            } while (op != 4);
            


        }
    }
}
