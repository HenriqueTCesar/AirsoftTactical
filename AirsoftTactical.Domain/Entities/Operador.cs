using AirsoftTactical.Domain.Commom;

namespace AirsoftTactical.Domain.Entities;

public class Operador : BaseEntity
{
    public string Nome { get; private set; }
    public string CallSign { get; private set; }
    public string Cpf { get; private set; }

    public Operador(string nome, string callSign, string cpf)
    {
        AtualizarNome(nome);
        UpdateCallSign(callSign);

        if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
            throw new Exception("CPF deve conter exatamente 11 dígitos.");
            
        Cpf = cpf;
    }
    public void AtualizarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("O nome não pode ser vazio.");
        Nome = nome.Trim();
    }

    public void UpdateCallSign(string callSign)
    {
        if (string.IsNullOrWhiteSpace(callSign))
            throw new Exception("O CallSign (vulgo) é obrigatório.");
        CallSign = callSign.Trim().ToUpper();
    }
}