using System; 
using System.Collections.Generic; // para usar colecoes genericas, tipo List<T>

public class Prova // criando classe Prova
{
    public DateTime Data { get; set; } // atributo data da prova
    public float Nota { get; set; } // atributo nota da prova

    public void VerNota() // metodo ver nota
    {
        Console.WriteLine($"Nota: {Nota}"); // imprime a nota da prova
    }

    public void AlterarNota(float novaNota) // metodo que altera a nota da prova
    {
        Nota = novaNota; // atribui nova nota ao atributo nota
    }
}

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

public class Professor // criando classe Professor
{
    public required string Nome { get; set; } // atributo nome do professor
    public required string Sobrenome { get; set; } // atributo sobrenome do Professor
    public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>(); // lista de disciplinas do professor vazia

    public void CorrigirProva(Prova prova, float nota) // metodo que corrige prova
    {
        prova.AlterarNota(nota); // chama o metodo AlterarNota da classe Prova
    }

    public void AtribuirDisciplina(Disciplina disciplina) // metodo que adiciona uma disciplina e lista de disciplinas do professor
    {
        Disciplinas.Add(disciplina); // adiciona a disciplina a lista de disciplinas
    }
}

public class Disciplina // criando classe Disciplina
{
    public required string Nome { get; set; } // atributo nome da disciplina
    public List<Prova> Provas { get; set; } = new List<Prova>(); // lista de provas em disciplina vazia

    public void AtribuirProva(Prova prova) // metodo que adiciona uma prova a disciplina
    {
        Provas.Add(prova); // adiciona a prova a lista de provas
    }
}

public class Aluno // criando a classe Aluno
{
    public required string Nome { get; set; } // atributo nome do aluno
    public required string Sobrenome { get; set; } // atributo sobrenome do aluno
    public List<Prova> Provas { get; set; } = new List<Prova>(); //  lista de provas do aluno vazia

    public void FazerProva(Prova prova) // metodo que o aluno faz a prova
    {
        Provas.Add(prova); // adiciona a prova a lista de provas
    }
}

// executando o programa
class Program
{
    static void Main()
    {
        // criando instancia de aluno e adicionando nome e sobrenome
        var aluno = new Aluno { Nome = "João", Sobrenome = "Silva" };

        // criando instancia de professor e adicionando nome e sobrenome
        var professor = new Professor { Nome = "Carlos", Sobrenome = "Santos" };

        // criando instancia de disciplina e adicionando nome
        var disciplina = new Disciplina { Nome = "Matemática" };

        // criando instancia de prova e adicionando data e nota, nota = 0, pois o aluno ainda nao fez a prova
        var prova = new Prova { Data = DateTime.Now, Nota = 0 };

        // criando instancia de turma e adicionando nome
        var turma = new Turma { Nome = "Turma A" };

        // adicionando aluno a turma
        turma.AtribuirAluno(aluno);

        // adicionando professor a turma
        turma.AtribuirProfessor(professor);

        // adicionando disciplina ao professor
        professor.AtribuirDisciplina(disciplina);

        // adicionando prova a disciplina
        disciplina.AtribuirProva(prova);

        // aluno faz a prova
        aluno.FazerProva(prova);

        // professor corrige a prova adicionando nota 8,5
        professor.CorrigirProva(prova, 8.5f);

        // imprimindo a nota da prova na tela
        prova.VerNota();
    }
}
