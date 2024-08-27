using System; 
using System.Collections.Generic; // para usar colecoes genericas, tipo List<T>

namespace Escola;

public class Turma // criando classe Turma
{
    public required string Nome { get; set; } // atributo nome da turma
    public List<Aluno> Alunos { get; set; } = new List<Aluno>(); // lista de alunos em turma vazia
    public List<Professor> Professores { get; set; } = new List<Professor>(); // lista de professores em turma vazia

    public void AtribuirAluno(Aluno aluno) // metodo que adiciona aluno a turma
    {
        Alunos.Add(aluno); // adiciona aluno a lista de alunos
    }

    public void AtribuirProfessor(Professor professor) // metodo que adiciona professor a turma
    {
        Professores.Add(professor); // adiciona professor a lista de professores
    }
}