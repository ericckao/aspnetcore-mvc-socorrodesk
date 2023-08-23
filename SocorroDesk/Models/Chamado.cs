namespace SocorroDesk.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public string Chapa { get; set; } = "38976";
        public string Departamento { get; set; } = "Gestão Imobiliária";
        public string? Assunto { get; set; }
        public DateTime UltimaAtualizacao { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Aguardando Atendimento";
        public string? Observacoes { get; set; }
    }
}
