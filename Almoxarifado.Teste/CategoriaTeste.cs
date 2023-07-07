using Almoxarifado.Classe;
using ExpectedObjects;

namespace Almoxarifado.Teste
{
    public class CategoriaTeste
    {
        private int _idCategory;
        private string _category;
        private string _description;
        private string _dtCreation;

        public CategoriaTeste()
        {
            _idCategory = 1;
            _category = "Categoria Teste";
            _description = "Essa é uma descrição de teste";
            _dtCreation = "2023-05-17";
        }

        [Fact]
        public void CriarCategoriaCorretamente()
        {
            var categoriaEsperada = new
            {
                IdCategory = _idCategory,
                Category = _category,
                Description = _description,
                DtCreation = _dtCreation
            };

            // Act
            Categoria novaCategoria = new Categoria(
                categoriaEsperada.IdCategory,
                categoriaEsperada.Category,
                categoriaEsperada.Description,
                categoriaEsperada.DtCreation
            );

            // Assert
            categoriaEsperada.ToExpectedObject().ShouldMatch(novaCategoria);
        }

        [Fact]
        public void LancarExcecaoAoCriarCategoriaSemID()
        {
            // Arrange
            int idCategory = 0;
            string category = "Categoria Teste";
            string description = "Essa é uma descrição de teste";
            string dtCreation = "2023-05-17";

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                new Categoria(idCategory, category, description, dtCreation)
            );
        }

        [Fact]
        public void LancarExcecaoAoCriarCategoriaSemCategoria()
        {
            // Arrange
            int idCategory = 1;
            string category = "";
            string description = "Essa é uma descrição de teste";
            string dtCreation = "2023-05-17";

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                new Categoria(idCategory, category, description, dtCreation)
            );
        }

        [Fact]
        public void LancarExcecaoAoCriarCategoriaSemDescricao()
        {
            // Arrange
            int idCategory = 1;
            string category = "Categoria Teste";
            string description = "";
            string dtCreation = "2023-05-17";

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                new Categoria(idCategory, category, description, dtCreation)
            );
        }

        [Fact]
        public void LancarExcecaoAoCriarCategoriaSemDataCriacao()
        {
            // Arrange
            int idCategory = 1;
            string category = "Categoria Teste";
            string description = "Essa é uma descrição de teste";
            string dtCreation = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                new Categoria(idCategory, category, description, dtCreation)
            );
        }
    }
}
