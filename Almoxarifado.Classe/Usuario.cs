using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado.Classe
{
    public class Usuario
    {
        //Campos
        private int codigo;
        private string nome;
        private string email;
        private string telefone;

        //Propriedades
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        //Metodo Construtor
        public Usuario(int codigo, string nome, string email, string telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;

            if (codigo < 1) throw new ArgumentException("O 'codigo' esta invalido");

            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("O 'nome' esta invalido");

            if (string.IsNullOrEmpty(email)) throw new ArgumentException("O 'email' esta invalido");

            if (string.IsNullOrEmpty(telefone)) throw new ArgumentException("O 'telefone' esta invalido");

        }
    }
}