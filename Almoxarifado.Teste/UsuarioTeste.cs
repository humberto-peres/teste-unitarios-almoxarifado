using Almoxarifado.Classe;
using ExpectedObjects;

namespace Almoxarifado.Teste
{
    public class UsuarioTeste
    {
        private int _codigo;
        private string _nome;
        private string _email;
        private string _telefone;

        public UsuarioTeste()
        {
            _codigo = 1;
            _nome = "Leandro Pellegrini Fodi";
            _email = "leandro.fodi@gmail.com";
            _telefone = "47 9999-9999";
        }

        [Fact]
        public void CadastrarUsuario()
        {
            //Arrange
            var usuarioEsperado = new
            {
                Codigo = _codigo,
                Nome = _nome,
                Email = _email,
                Telefone = _telefone
            };

            //Act
            Usuario novoUsuario = new Usuario(
                usuarioEsperado.Codigo,
                usuarioEsperado.Nome,
                usuarioEsperado.Email,
                usuarioEsperado.Telefone
            );

            //Assert
            usuarioEsperado.ToExpectedObject().ShouldMatch(novoUsuario);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void UsuarioCodigoInvalido(int codigo)
        {
            var mensagem = Assert.Throws<ArgumentException>(() =>
                new Usuario(codigo, _nome, _email, _telefone)
            ).Message;
            Assert.Equal("O 'codigo' esta invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void UsuarioNomeInvalido(string nome)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Usuario(_codigo, nome, _email, _telefone)
            ).Message;
            Assert.Equal("O 'nome' esta invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void UsuarioEmailInvalido(string email)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Usuario(_codigo, _nome, email, _telefone)
            ).Message;
            Assert.Equal("O 'email' esta invalido", mensagem);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void UsuarioTelefoneInvalido(string telefone)
        {
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Usuario(_codigo, _nome, _email, telefone)
            ).Message;
            Assert.Equal("O 'telefone' esta invalido", mensagem);
        }
    }
}