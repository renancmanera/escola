using System; 
using System.Collections.Generic; // para usar colecoes genericas, tipo List<T>

namespace Escola;

public class Aluno // criando a classe Aluno
{
    public required string Nome { get; set; } // atributo nome do aluno
    public required string Sobrenome { get; set; } // atributo sobrenome do aluno
    public float Nota { get; set; }
}