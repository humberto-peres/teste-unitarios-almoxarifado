using Almoxarifado.Classe;
using ExpectedObjects;

namespace Almoxarifado.Teste
{
    public class TesteMovimentacap
    {
        private int _idMovement;
        private string _date;
        private string _product;
        private string _type;
        private string _quantity;
        private string _origin;
        private string _destination;

        public TesteMovimentacap()
        {
            _idMovement = 1;
            _date = "2023-05-17";
            _product = "Produto de teste";
            _type = "Entrada";
            _quantity = "50";
            _origin = "Armazem A";
            _destination = "Armazem B";
        }


        [Fact]
        public void CriarMovimentacao()
        {
            //Arrange
            var movimentacaoEsperado = new
            {
                IdMovement = _idMovement,
                Date = _date,
                Product = _product,
                Type = _type,
                Quantity = _quantity,
                Origin = _origin,
                Destination = _destination
            };

            //Act
            Movimentacao novoMovimentacao = new Movimentacao(
                movimentacaoEsperado.IdMovement,
                movimentacaoEsperado.Date,
                movimentacaoEsperado.Product,
                movimentacaoEsperado.Type,
                movimentacaoEsperado.Quantity,
                movimentacaoEsperado.Origin,
                movimentacaoEsperado.Destination
            );

            //Assert
            movimentacaoEsperado.ToExpectedObject().ShouldMatch(novoMovimentacao);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void MovimentacaoIdMovimentInvalido(int idMovement)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Movimentacao(idMovement, _date, _product, _type, _quantity, _origin, _destination)
            ).Message;
            Assert.Equal("Id de Movimentacao Invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentacaoDateInvalido(string date)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Movimentacao(_idMovement, date, _product, _type, _quantity, _origin, _destination)
            ).Message;
            Assert.Equal("Data Invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentacaoProductInvalido(string product)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Movimentacao(_idMovement, _date, product, _type, _quantity, _origin, _destination)
            ).Message;
            Assert.Equal("Produto Invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentacaoTypeInvalido(string type)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Movimentacao(_idMovement, _date, _product, type, _quantity, _origin, _destination)
            ).Message;
            Assert.Equal("Tipo Invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentacaoQuantityInvalido(string quantity)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Movimentacao(_idMovement, _date, _product, _type, quantity, _origin, _destination)
            ).Message;
            Assert.Equal("Quantidade Invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentacaoOriginInvalido(string origin)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Movimentacao(_idMovement, _date, _product, _type, _quantity, origin, _destination)
            ).Message;
            Assert.Equal("Origem Invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void MovimentacaoDestinationInvalido(string destination)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Movimentacao(_idMovement, _date, _product, _type, _quantity, _origin, destination)
            ).Message;
            Assert.Equal("Destino Invalido", mensagem);
        }

    }
}