using AirsoftTactical.Domain.Commom;
using AirsoftTactical.Domain.Enum;

namespace AirsoftTactical.Domain.Entities;

public class Equipamento : BaseEntity
{
    public string Modelo { get; private set; }
    public double PotenciaFps { get; private set; }
    public TipoEquipamento Tipo { get; private set; }
    
    // Relacionamento: Todo equipamento pertence a um operador
    public Guid OperadorId { get; private set; }

    public Equipamento(string modelo, double potenciaFps, TipoEquipamento tipo, Guid operadorId)
    {
        if (string.IsNullOrWhiteSpace(modelo)) throw new Exception("O modelo do equipamento é obrigatório.");
        if (potenciaFps <= 0) throw new Exception("O FPS deve ser maior que zero.");
        if (operadorId == Guid.Empty) throw new Exception("O ID do operador é obrigatório.");

        Modelo = modelo;
        PotenciaFps = potenciaFps;
        Tipo = tipo;
        OperadorId = operadorId;
    }
}