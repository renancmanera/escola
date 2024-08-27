using System;
using System.Collections.Generic;
using System.Linq;

namespace Escola
{
    class Program
    {
        static List<Turma> Turmas = new List<Turma>();

        static void Main()
        {
            // Criação de dados genéricos
            var aluno1 = new Aluno { Nome = "João", Sobrenome = "Silva", Nota = 8.5f };
            var aluno2 = new Aluno { Nome = "Maria", Sobrenome = "Oliveira", Nota = 7.0f };
            var aluno3 = new Aluno { Nome = "Pedro", Sobrenome = "Santos", Nota = 9.0f };

            var turma1 = new Turma { Nome = "Turma A" };
            var turma2 = new Turma { Nome = "Turma B" };

            turma1.AtribuirAluno(aluno1);
            turma1.AtribuirAluno(aluno2);
            turma2.AtribuirAluno(aluno3);

            Turmas.Add(turma1);
            Turmas.Add(turma2);

            int opcao;
            do
            {
                Console.WriteLine("\n1. Ver Nota");
                Console.WriteLine("2. Ver Quantidade de Alunos na Escola");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out opcao))
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        VerNota();
                        break;
                    case 2:
                        VerQuantidadeDeAlunos();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 3);
        }

        static void VerNota()
        {
            Console.WriteLine("\nTurmas Disponíveis:");
            for (int i = 0; i < Turmas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Turmas[i].Nome}");
            }

            Console.Write("Escolha uma turma: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int indiceTurma) || indiceTurma < 1 || indiceTurma > Turmas.Count)
            {
                Console.WriteLine("Turma inválida.");
                return;
            }

            var turma = Turmas[indiceTurma - 1];
            Console.WriteLine($"\nAlunos na turma {turma.Nome}:");
            for (int i = 0; i < turma.Alunos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {turma.Alunos[i].Nome} {turma.Alunos[i].Sobrenome}");
            }

            Console.Write("Escolha um aluno: ");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int indiceAluno) || indiceAluno < 1 || indiceAluno > turma.Alunos.Count)
            {
                Console.WriteLine("Aluno inválido.");
                return;
            }

            var aluno = turma.Alunos[indiceAluno - 1];
            Console.WriteLine($"Nota do aluno {aluno.Nome} {aluno.Sobrenome}: {aluno.Nota}");
        }

        static void VerQuantidadeDeAlunos()
        {
            int totalAlunos = Turmas.Sum(t => t.Alunos.Count);
            Console.WriteLine($"Total de alunos na escola: {totalAlunos}");
        }
    }
}

 
