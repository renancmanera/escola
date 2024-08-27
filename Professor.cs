using System; 
using System.Collections.Generic; // para usar colecoes genericas, tipo List<T>

namespace Escola;

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