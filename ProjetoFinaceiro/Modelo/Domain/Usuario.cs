 using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;

namespace apiProjetoFinaceiro.Model.Domain
{
    public class Usuario
    {

        protected Usuario()
        {

        }
        public Usuario(string nome, string senha, string email, string telefone, Cidade cidade, Bairro bairro, string cPF, DateTime dataNascimento, string situacao)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            Telefone = telefone;
            Cidade = cidade;
            Bairro = bairro;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Situacao = situacao;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do Usuario Obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Senha do Usuario Obrigatoria")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Email do Usuario Obrigatorio")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefone do Usuario Obrigatorio")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Cidade Obrigatoria")]
        public Cidade Cidade { get; set; }
        [Required(ErrorMessage = "Bairro Obrigatorio")]
        public Bairro Bairro { get; set; }
        [Required(ErrorMessage = "CPF do Usuario Obrigatorio")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Data de nascimento Obrigatoria")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Situação obrigatoria")]
        public string Situacao { get; set; }
    }
}

