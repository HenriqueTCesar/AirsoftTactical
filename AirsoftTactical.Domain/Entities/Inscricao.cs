using AirsoftTactical.Domain.Commom;

namespace AirsoftTactical.Domain.Entities;

public class Inscricao : BaseEntity
{
    public Guid OperadorId { get; private set; }
    public Guid PartidaId { get; private set; }
    public bool Pago { get; private set; }

    public Inscricao(Guid operadorId, Guid partidaId)
    {
        if (operadorId == Guid.Empty || partidaId == Guid.Empty)
            throw new Exception("Operador e Partida são obrigatórios para a inscrição.");

        OperadorId = operadorId;
        PartidaId = partidaId;
        Pago = false;
    }

    public void ConfirmarPagamento() => Pago = true;
}