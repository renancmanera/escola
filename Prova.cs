using System; 
using System.Collections.Generic; // para usar colecoes genericas, tipo List<T>

namespace Escola;

public class Prova // criando classe Prova
{
    public DateTime Data { get; set; } // atributo data da prova
    public float? Nota { get; set; } // atributo nota da prova, pode ser nula se nao houver nota

public void VerNota()
    {
        if (Nota.HasValue) // verifica se a nota tem valor
            Console.WriteLine($"Nota: {Nota}"); 
        else
            Console.WriteLine("Prova ainda não corrigida.");
    }

    public void AlterarNota(float? novaNota) // metodo que altera a nota da prova
    {
        Nota = novaNota; // atribui nova nota ao atributo nota
    }
}