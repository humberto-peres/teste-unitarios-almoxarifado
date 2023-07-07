using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado.Classe
{
    public class Movimentacao
    {
        private int idMovement;
        private string date;
        private string product;
        private string type;
        private string quantity;
        private string origin;
        private string destination;

        public Movimentacao(int idMovement, string date, string product, string type, string quantity, string origin, string destination)
        {
            this.IdMovement = idMovement;
            this.Date = date;
            this.Product = product;
            this.Type = type;
            this.Quantity = quantity;
            this.Origin = origin;
            this.Destination = destination;

            if (idMovement < 1) throw new ArgumentException("Id de Movimentacao Invalido");

            if (string.IsNullOrEmpty(date)) throw new ArgumentException("Data Invalido");

            if (string.IsNullOrEmpty(product)) throw new ArgumentException("Produto Invalido");

            if (string.IsNullOrEmpty(type)) throw new ArgumentException("Tipo Invalido");

            if (string.IsNullOrEmpty(quantity)) throw new ArgumentException("Quantidade Invalido");

            if (string.IsNullOrEmpty(origin)) throw new ArgumentException("Origem Invalido");

            if (string.IsNullOrEmpty(destination)) throw new ArgumentException("Destino Invalido");
        }

        public int IdMovement { get => idMovement; set => idMovement = value; }
        public string Date { get => date; set => date = value; }
        public string Product { get => product; set => product = value; }
        public string Type { get => type; set => type = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
    }
}

