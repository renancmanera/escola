using System; 
using System.Collections.Generic; // para usar colecoes genericas, tipo List<T>

namespace Escola;

public class Disciplina // criando classe Disciplina
{
    public required string Nome { get; set; } // atributo nome da disciplina
    public List<Prova> Provas { get; set; } = new List<Prova>(); // lista de provas em disciplina vazia

    public void AtribuirProva(Prova prova) // metodo que adiciona uma prova a disciplina
    {
        Provas.Add(prova); // adiciona a prova a lista de provas
    }
}