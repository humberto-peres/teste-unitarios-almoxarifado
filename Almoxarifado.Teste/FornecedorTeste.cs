using Almoxarifado.Classe;
using ExpectedObjects;

namespace Almoxarifado.Teste
{
    public class FornecedorTeste
    {
        private int _idProvider;
        private string _name;
        private string _address;
        private string _email;
        private string _phone;

        public FornecedorTeste()
        {
            _idProvider = 1;
            _name = "Fornecedor teste";
            _address = "Rua Paulo Malschitzki, 200";
            _email = "teste@teste.com";
            _phone = "(47) 99115-2348";
        }

        [Fact]
        public void CadastrarFornecedor()
        {
            var fornecedorEsperado = new
            {
                IdProvider = _idProvider,
                Name = _name,
                Address = _address,
                Email = _email,
                Phone = _phone
            };

            // Act
            Fornecedor novoFornecedor = new Fornecedor(
                fornecedorEsperado.IdProvider,
                fornecedorEsperado.Name,
                fornecedorEsperado.Address,
                fornecedorEsperado.Email,
                fornecedorEsperado.Phone
            );

            // Assert
            fornecedorEsperado.ToExpectedObject().ShouldMatch(novoFornecedor);
        }

        [Theory]
        [InlineData(null)]
        public void FornecedorIdInvalido(int idProvider)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Fornecedor(idProvider, _name, _address, _email, _phone)
            ).Message;
            Assert.Equal("Id Inválido!", mensagem);
        }

        [Theory]
        [InlineData("")]
        public void FornecedorNomeInvalido(string name)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Fornecedor(_idProvider, name, _address, _email, _phone)
            ).Message;
            Assert.Equal("Nome Inválido!", mensagem);
        }

        [Theory]
        [InlineData("")]
        public void FornecedorEnderecoInvalido(string address)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Fornecedor(_idProvider, _name, address, _email, _phone)
            ).Message;
            Assert.Equal("Endereço Inválido!", mensagem);
        }

        [Theory]
        [InlineData("")]
        public void FornecedorEmailInvalido(string email)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Fornecedor(_idProvider, _name, _address, email, _phone)
            ).Message;
            Assert.Equal("E-mail Inválido!", mensagem);
        }

        [Theory]
        [InlineData("")]
        public void FornecedorTelefoneInvalido(string phone)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Fornecedor(_idProvider, _name, _address, _email, phone)
            ).Message;
            Assert.Equal("Telefone Inválido!", mensagem);
        }
    }
}
