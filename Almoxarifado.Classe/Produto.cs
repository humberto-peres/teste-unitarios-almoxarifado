using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado.Classe
{
    public class Produto
    {
        //Campos
        private int idProduct;
        private string nome;
        private int qtdEstoque;
        private string unidMedida;
        private double preco;
        private string fornecedor;
        private string dtCreation;

        //Propriedades
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string Nome { get => nome; set => nome = value; }
        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public string UnidMedida { get => unidMedida; set => unidMedida = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public string DtCreation { get => dtCreation; set => dtCreation = value; }

        //Metodo Construtor
        public Produto(int idProduct, string nome, int qtdEstoque, string unidMedida, double preco, string fornecedor, string dtCreation)
        {
            this.IdProduct = idProduct;
            this.Nome = nome;
            this.QtdEstoque = qtdEstoque;
            this.UnidMedida = unidMedida;
            this.Preco = preco;
            this.Fornecedor = fornecedor;
            this.DtCreation = dtCreation;

            if (idProduct < 1) throw new ArgumentException("O codigo do produto esta invalido");

            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("O nome do produto esta invalido");

            if (qtdEstoque < 0) throw new ArgumentException("A quantidade de estoque do produto esta invalida");

            if (string.IsNullOrEmpty(unidMedida)) throw new ArgumentException("A unidade de medida do produto esta invalida");

            if (preco < 1) throw new ArgumentException("O preco do produto esta invalido");

            if (string.IsNullOrEmpty(fornecedor)) throw new ArgumentException("O fornecedor do produto esta invalido");

            if (string.IsNullOrEmpty(dtCreation)) throw new ArgumentException("A data de criacao do produto esta invalida");

        }
    }
}
