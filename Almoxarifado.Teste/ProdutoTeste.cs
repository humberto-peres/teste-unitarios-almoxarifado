using Almoxarifado.Classe;
using ExpectedObjects;

namespace Almoxarifado.Teste
{
    public class ProdutoTeste
    {
        private int _idProduct;
        private string _nome;
        private int _qtdEstoque;
        private string _unidMedida;
        private double _preco;
        private string _fornecedor;
        private string _dtCreation;

        public ProdutoTeste()
        {
            _idProduct = 1;
            _nome = "Moby Dick";
            _qtdEstoque = 15;
            _unidMedida = "metros";
            _preco = 50.99;
            _fornecedor = "Fornecedor teste";
            _dtCreation = "2023-05-16";
        }


        [Fact]
        public void CadastrarProduto()
        {
            var produtoEsperado = new
            {
                IdProduct = _idProduct,
                Nome = _nome,
                QtdEstoque = _qtdEstoque,
                UnidMedida = _unidMedida,
                Preco = _preco,
                Fornecedor = _fornecedor,
                DtCreation = _dtCreation
            };

            // Act
            Produto novoProduto = new Produto(
                produtoEsperado.IdProduct,
                produtoEsperado.Nome,
                produtoEsperado.QtdEstoque,
                produtoEsperado.UnidMedida,
                produtoEsperado.Preco,
                produtoEsperado.Fornecedor,
                produtoEsperado.DtCreation
            );

            //Assert
            produtoEsperado.ToExpectedObject().ShouldMatch(novoProduto);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ProdutoCodigoInvalido(int idProduct)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Produto(idProduct, _nome, _qtdEstoque, _unidMedida, _preco, _fornecedor, _dtCreation)
            ).Message;
            Assert.Equal("O codigo do produto esta invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoNomeInvalido(string nome)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Produto(_idProduct, nome, _qtdEstoque, _unidMedida, _preco, _fornecedor, _dtCreation)
            ).Message;
            Assert.Equal("O nome do produto esta invalido", mensagem);
        }

        [Theory]
        [InlineData(-1)]
        public void ProdutoQtdEstoqueInvalido(int qtdEstoque)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Produto(_idProduct, _nome, qtdEstoque, _unidMedida, _preco, _fornecedor, _dtCreation)
            ).Message;
            Assert.Equal("A quantidade de estoque do produto esta invalida", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoUnidadeMedidaInvalido(string unidMedida)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Produto(_idProduct, _nome, _qtdEstoque, unidMedida, _preco, _fornecedor, _dtCreation)
            ).Message;
            Assert.Equal("A unidade de medida do produto esta invalida", mensagem);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ProdutoPrecoInvalido(int preco)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Produto(_idProduct, _nome, _qtdEstoque, _unidMedida, preco, _fornecedor, _dtCreation)
            ).Message;
            Assert.Equal("O preco do produto esta invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoFornecedorInvalido(string fornecedor)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Produto(_idProduct, _nome, _qtdEstoque, _unidMedida, _preco, fornecedor, _dtCreation)
            ).Message;
            Assert.Equal("O fornecedor do produto esta invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ProdutoDataInvalida(string dtCreation)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Produto(_idProduct, _nome, _qtdEstoque, _unidMedida, _preco, _fornecedor, dtCreation)
            ).Message;
            Assert.Equal("A data de criacao do produto esta invalida", mensagem);
        }


    }
}