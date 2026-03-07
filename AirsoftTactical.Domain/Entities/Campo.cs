using AirsoftTactical.Domain.Commom;

namespace AirsoftTactical.Domain.Entities;

public class Campo : BaseEntity
{
    public string Nome { get; private set; }
    public string Endereco { get; private set; }
    public bool PossuiAreaCqb { get; private set; }

    public Campo(string nome, string endereco, bool possuiAreaCqb)
    {
        AtualizarNome(nome);
        if (string.IsNullOrWhiteSpace(endereco)) throw new Exception("Endereço é obrigatório.");
        
        Endereco = endereco;
        PossuiAreaCqb = possuiAreaCqb;
    }

    public void AtualizarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new Exception("Nome do campo inválido.");
        Nome = nome.Trim();
    }
}