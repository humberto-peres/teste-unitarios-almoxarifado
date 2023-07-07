using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado.Classe
{
    public class Categoria
    {
        // Campos
        private int idCategory;
        private string category;
        private string description;
        private string dtCreation;

        // Propriedades
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public string DtCreation { get => dtCreation; set => dtCreation = value; }

        // Método Construtor
        public Categoria(int idCategory, string category, string description, string dtCreation)
        {
            IdCategory = idCategory;
            Category = category;
            Description = description;
            DtCreation = dtCreation;

            if (idCategory < 1)
                throw new ArgumentException("Id Inválido!");

            if (string.IsNullOrEmpty(category))
                throw new ArgumentException("Categoria Inválida!");

            if (string.IsNullOrEmpty(description))
                throw new ArgumentException("Descrição Inválida!");

            if (string.IsNullOrEmpty(dtCreation))
                throw new ArgumentException("Data de criação Inválida!");
        }
    }
}