using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado.Classe
{
    public class Fornecedor
    {
        // Campos
        private int idProvider;
        private string name;
        private string address;
        private string email;
        private string phone;

        // Propriedades
        public int IdProvider { get => idProvider; set => idProvider = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        // Método Construtor
        public Fornecedor(int idProvider, string name, string address, string email, string phone)
        {
            this.IdProvider = idProvider;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;

            if (idProvider < 1) throw new ArgumentException("Id Inválido!");

            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Nome Inválido!");

            if (string.IsNullOrEmpty(address)) throw new ArgumentException("Endereço Inválido!");

            if (string.IsNullOrEmpty(email)) throw new ArgumentException("E-mail Inválido!");

            if (string.IsNullOrEmpty(phone)) throw new ArgumentException("Telefone Inválido!");
        }
    }
}

