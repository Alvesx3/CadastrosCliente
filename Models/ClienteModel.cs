namespace CadastrosCliente.Models
{
    public class ClienteModel:BaseModel
    {
        public ClienteModel()
        {
        }

        public ClienteModel(string? nome, DateTime? dataNascimento, int? dDD, int? telefone, int? cEP, string? endereco, int? numero, string? complemento, string? bairro, string estado,int iD)
        {
            Nome = nome;
            DataNascimento = dataNascimento >= DateTime.Now ? throw new ArgumentException("Data Invalida") : dataNascimento;
            DDD = dDD;
            Telefone = telefone;
            CEP = cEP;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Id = iD;
        }

        public string? Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? DDD { get; set; }
        public int? Telefone { get; set; }
        public int? CEP { get; set; }
        public string? Endereco { get; set; }
        public int? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string Estado { get; set; }
    }
}
