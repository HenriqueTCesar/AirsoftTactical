using AirsoftTactical.Domain.Commom;

namespace AirsoftTactical.Domain.Entities;

public class Time : BaseEntity
{
    public string Nome { get; private set; }
    public string Tag { get; private set; }
    
    // Relacionamento: Um time tem uma lista de membros (Operadores)
    public List<Operador> Membros { get; private set; }

    public Time(string nome, string tag)
    {
        AtualizarNome(nome);
        
        if (string.IsNullOrWhiteSpace(tag) || tag.Length > 5)
            throw new Exception("A Tag do time deve ter entre 1 e 5 caracteres.");
            
        Tag = tag.Trim().ToUpper();
        Membros = new List<Operador>();
    }

    public void AtualizarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            throw new Exception("O nome do time deve ter pelo menos 3 caracteres.");
            
        Nome = nome.Trim();
    }
    
    public void AdicionarMembro(Operador operador)
    {
        if (operador == null) throw new Exception("Operador inválido.");
        Membros.Add(operador);
    }
}