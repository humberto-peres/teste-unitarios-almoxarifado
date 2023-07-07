# Testes unitários do sistema de estoque

## Almoxarifado
O projeto contém as classes de domínio relacionadas a um sistema de almoxarifado. Cada classe representa uma entidade específica do sistema.

### :clipboard: Classe Categoria
A classe **Categoria** representa uma categoria de produtos no almoxarifado.

#### `Propriedades:`
- IdCategory (int): identificador da categoria.<br>
- Category (string): nome da categoria.<br>
- Description (string): descrição da categoria.<br>
- DtCreation (string): data de criação da categoria.<br>

#### `Método Construtor:`
```
Categoria(int idCategory, string category, string description, string dtCreation)
```
- Cria uma nova instância da classe Categoria com os valores fornecidos. Lança exceções se os valores fornecidos forem inválidos.

### :office: Classe Fornecedor
A classe **Fornecedor** representa um fornecedor de produtos.

#### `Propriedades:`

- IdProvider (int): identificador do fornecedor.
- Name (string): nome do fornecedor.
- Address (string): endereço do fornecedor.
- Email (string): e-mail do fornecedor.
- Phone (string): telefone do fornecedor.

#### `Método Construtor:`
```
Fornecedor(int idProvider, string name, string address, string email, string phone)
```

- Cria uma nova instância da classe Fornecedor com os valores fornecidos. Lança exceções se os valores fornecidos forem inválidos.

### :truck: Classe Movimentacao 
A classe Movimentacao representa uma movimentação de produtos no almoxarifado.

#### `Propriedades:`

- IdMovement (int): identificador da movimentação.
- Date (string): data da movimentação.
- Product (string): produto envolvido na movimentação.
- Type (string): tipo da movimentação.
- Quantity (string): quantidade movimentada.
- Origin (string): origem da movimentação.
- Destination (string): destino da movimentação.

#### `Método Construtor:`
```
Movimentacao(int idMovement, string date, string product, string type, string quantity, string origin, string destination)
```
- Cria uma nova instância da classe Movimentacao com os valores fornecidos. Lança exceções se os valores fornecidos forem inválidos.

### :ledger: Classe Produto
A classe Produto representa um produto no almoxarifado.

#### `Propriedades:`

- IdProduct (int): identificador do produto.
- Nome (string): nome do produto.
- QtdEstoque (int): quantidade em estoque do produto.
- UnidMedida (string): unidade de medida do produto.
- Preco (double): preço do produto.
- Fornecedor (string): fornecedor do produto.
- DtCreation (string): data de criação do produto.

#### `Método Construtor:`
```
Produto(int idProduct, string nome, int qtdEstoque, string unidMedida, double preco, string fornecedor, string dtCreation)
```
- Cria uma nova instância da classe Produto com os valores fornecidos. Lança exceções se os valores fornecidos forem inválidos.

### :office_worker: Classe Usuario
A classe Usuario representa um usuário do sistema de almoxarifado.

#### `Propriedades:`

- Codigo (int): código do usuário.
- Nome (string): nome do usuário.
- Email (string): e-mail do usuário.
- Telefone (string): telefone do usuário.

#### `Método Construtor:`
```
Usuario(int codigo, string nome, string email, string telefone)
``` 
- Cria uma nova instância da classe Usuario com os valores fornecidos. Lança exceções se os valores fornecidos forem inválidos.

## Testes
O projeto também inclui testes unitários para as classes de domínio. Os testes são escritos utilizando a biblioteca xUnit.net e a biblioteca ExpectedObjects para facilitar a comparação de objetos esperados com objetos obtidos durante os testes.

Os testes garantem que as propriedades das classes de domínio estejam sendo definidas corretamente e que as exceções são lançadas quando os valores fornecidos são inválidos.

### `Integrantes`
Humberto Peres da Rocha Filho<br>
Israel Schroeder Moreira<br>
Leandro Pellegrini Fodi<br>
Vítor de Oliveira Celestino da Silva<br>
Weslly Hendler Neres<br>
