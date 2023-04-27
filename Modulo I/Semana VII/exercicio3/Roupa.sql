-- Tabela de Produtos
CREATE TABLE Produtos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    Preco DECIMAL(10, 2) CHECK (Preco > 50.00),
    Tamanho VARCHAR(10) NOT NULL
);

-- Tabela de Pedidos
CREATE TABLE Pedidos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DataPedido DATE NOT NULL,
    FormaPagamento VARCHAR(50) NOT NULL,
    EnderecoEntrega VARCHAR(200) NOT NULL
);

-- Tabela de ProdutosPedidos (tabela de relacionamento entre Produtos e Pedidos)
CREATE TABLE ProdutosPedidos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    PedidoID INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    FOREIGN KEY (PedidoID) REFERENCES Pedidos(ID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ID)
);
