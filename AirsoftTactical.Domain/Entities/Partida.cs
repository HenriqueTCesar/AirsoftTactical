using AirsoftTactical.Domain.Commom;

namespace AirsoftTactical.Domain.Entities;

public class Partida : BaseEntity
{
    public DateTime DataHora { get; private set; }
    public int LimiteJogadores { get; private set; }
    
    // Relacionamento: Toda Partida ocorre em um Campo
    public Guid CampoId { get; private set; }

    public Partida(DateTime dataHora, int limiteJogadores, Guid campoId)
    {
        if (dataHora < DateTime.Now) throw new Exception("A partida não pode ser marcada para o passado.");
        if (limiteJogadores < 4) throw new Exception("Mínimo de 4 jogadores para uma partida de CQB.");
        if (campoId == Guid.Empty) throw new Exception("Campo obrigatório.");

        DataHora = dataHora;
        LimiteJogadores = limiteJogadores;
        CampoId = campoId;
    }
}