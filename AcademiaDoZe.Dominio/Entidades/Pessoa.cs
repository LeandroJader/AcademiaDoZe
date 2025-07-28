namespace AcademiaDoZe.Dominio.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public Logradouro NomeLogradouro { get; set; }
        public int Numero { get; set; }
        public int Complemento { get; set; }
        public Pessoa(string nome, string cpf, DateOnly dataNascimento, string telefone, string email, string senha, string foto, Logradouro nomelogradouro, int numero, int complemento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Foto = foto;
            NomeLogradouro = nomelogradouro;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
//leandro jader