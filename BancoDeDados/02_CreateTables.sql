USE MusicStation;
GO

-- 1. TABELA USUARIOS
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY (1,1) PRIMARY KEY,
    nome VARCHAR(200) NOT NULL,
    email VARCHAR(256) NOT NULL UNIQUE,
    usuario_nome VARCHAR(50) UNIQUE NOT NULL,
    senha VARCHAR(255) NOT NULL,
    data_cadastro DATETIME NOT NULL
);

-- 2. TABELA CLIENTES
CREATE TABLE Clientes(
	id_cliente INT IDENTITY (1,1) PRIMARY KEY,
	usuario_id INT NOT NULL UNIQUE,
	telefone VARCHAR(20) NOT NULL,
	rua VARCHAR (100) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

-- 3. TABELA ADMINISTRADORES
CREATE TABLE Administradores(
	id_admin INT IDENTITY (1,1) PRIMARY KEY,
	usuario_id INT NOT NULL UNIQUE,
	nivel_acesso VARCHAR(10) NOT NULL,
	data_criacao DATE NOT NULL,
	observacoes VARCHAR(200),
	FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

-- 4. TABELA PROFISSIONAIS
CREATE TABLE Profissionais (
    id_profissional INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL UNIQUE,
    telefone VARCHAR(20) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

-- 5. TABELA FORMAS_PAGAMENTO
CREATE TABLE Formas_Pagamento (
    id_pagamento INT IDENTITY(1,1) PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL UNIQUE
);

-- 6. TABELA CARGOS
CREATE TABLE Cargos (
    id_cargo INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE,
    descricao VARCHAR(500) NOT NULL
);

-- 7. TABELA SERVICOS
CREATE TABLE Servicos (
    id_servico INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE,
    descricao VARCHAR(300) NOT NULL,
    preco DECIMAL(10,2) NOT NULL
);

-- 8. TABELA PEDIDOS
CREATE TABLE Pedidos (
    id_pedido INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT NOT NULL,
    data_pedido DATE NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    status VARCHAR(50) NOT NULL
        CHECK (status IN ('Pendente', 'Em andamento', 'Concluído', 'Cancelado')),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente)
);

-- 9. TABELA CHATS
CREATE TABLE Chats (
    id_chat INT IDENTITY(1,1) PRIMARY KEY,
    usuario1_id INT NOT NULL,
    usuario2_id INT NOT NULL,
    data_criacao DATETIME NOT NULL,
    FOREIGN KEY (usuario1_id) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (usuario2_id) REFERENCES Usuarios(id_usuario)
);

-- 10. TABELA NOTIFICACOES
CREATE TABLE Notificacoes (
    id_notificacao INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    mensagem VARCHAR(300) NOT NULL,
    tipo VARCHAR(50) NOT NULL
        CHECK (tipo IN ('sistema', 'agendamento', 'mensagem', 'promocao')),
    data_envio DATETIME NOT NULL,
    lida BIT NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

-- 11. TABELA SERVICOS_PEDIDOS
CREATE TABLE Servicos_Pedidos (
    id_item INT IDENTITY(1,1) PRIMARY KEY,
    pedido_id INT NOT NULL,
    servico_id INT NOT NULL,
    profissional_id INT NOT NULL,
    valor_servico DECIMAL(10,2) NOT NULL,
    observacao VARCHAR(200) DEFAULT '-',
    FOREIGN KEY (pedido_id) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (servico_id) REFERENCES Servicos(id_servico),
    FOREIGN KEY (profissional_id) REFERENCES Profissionais(id_profissional)
);

-- 12. TABELA AVALIACOES
CREATE TABLE Avaliacoes (
    id_avaliacao INT IDENTITY(1,1) PRIMARY KEY,
    servico_pedido_id INT NOT NULL UNIQUE,
    cliente_id INT NOT NULL,
    nota INT NOT NULL CHECK (nota BETWEEN 1 AND 5),
    comentario VARCHAR(300),
    data_avaliacao DATE NOT NULL,
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente),
    FOREIGN KEY (servico_pedido_id) REFERENCES Servicos_Pedidos(id_item)
);

-- 13. TABELA EMPRESAS
CREATE TABLE Empresas (
    id_empresa INT IDENTITY(1,1) PRIMARY KEY,
    usuario_id INT NOT NULL UNIQUE,
    nome_fantasia VARCHAR(150) NOT NULL,
    razao_social VARCHAR(150) NOT NULL UNIQUE,
    cnpj VARCHAR(20) NOT NULL UNIQUE,
    email VARCHAR(256) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    descricao VARCHAR(300),
    data_cadastro DATE NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(id_usuario)
);

-- 14. TABELA INSTRUMENTOS
CREATE TABLE Instrumentos (
    id_instrumento INT IDENTITY(1,1) PRIMARY KEY,
    empresa_id INT NOT NULL,
    nome VARCHAR(150) NOT NULL,
    descricao VARCHAR(300) NOT NULL,
    preco_locacao DECIMAL(10,2) NOT NULL,
    disponivel BIT NOT NULL,
    FOREIGN KEY (empresa_id) REFERENCES Empresas(id_empresa)
);

-- 15. TABELA LOCACOES
CREATE TABLE Locacoes (
    id_locacao INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT NOT NULL,
    data_inicio DATE NOT NULL,
    data_fim DATE NOT NULL,
    valor_total DECIMAL(10,2),
    status VARCHAR(50) NOT NULL
        CHECK (status IN ('ativa', 'concluída', 'atrasada', 'cancelada')),
    FOREIGN KEY (cliente_id) REFERENCES Clientes(id_cliente)
);

-- 16. TABELA LOCACAO_ITENS
CREATE TABLE Locacao_Itens (
    id_item INT IDENTITY(1,1) PRIMARY KEY,
    locacao_id INT NOT NULL,
    instrumento_id INT NOT NULL,
    preco_locacao DECIMAL(10,2) NOT NULL,
    dias INT NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    UNIQUE (locacao_id, instrumento_id),
    FOREIGN KEY (locacao_id) REFERENCES Locacoes(id_locacao),
    FOREIGN KEY (instrumento_id) REFERENCES Instrumentos(id_instrumento)
);

-- 17. TABELA PAGAMENTOS
CREATE TABLE Pagamentos (
    id_pagamento INT IDENTITY(1,1) PRIMARY KEY,
    pedido_id INT NOT NULL,
    forma_pagamento_id INT NOT NULL,
    data_pagamento DATE NOT NULL,
    valor_pago DECIMAL(10,2) NOT NULL,
    status VARCHAR(50) NOT NULL
        CHECK (status IN ('pendente', 'aprovado', 'recusado', 'reembolsado')),
    FOREIGN KEY (pedido_id) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (forma_pagamento_id) REFERENCES Formas_Pagamento(id_pagamento)
);

-- 18. TABELA TRANSACOES_PAGAMENTO
CREATE TABLE Transacoes_Pagamento (
    id_transacao INT IDENTITY(1,1) PRIMARY KEY,
    pagamento_id INT NOT NULL UNIQUE,
    status VARCHAR(50) NOT NULL
        CHECK (status IN ('processando', 'aprovado', 'recusado', 'falha')),
    codigo_externo VARCHAR(50) NOT NULL UNIQUE,
    data_transacao DATETIME NOT NULL,
    FOREIGN KEY (pagamento_id) REFERENCES Pagamentos(id_pagamento)
);

-- 19. TABELA MENSAGENS
CREATE TABLE Mensagens (
    id_mensagem INT IDENTITY(1,1) PRIMARY KEY,
    chat_id INT NOT NULL,
    remetente_id INT NOT NULL,
    conteudo VARCHAR(500) NOT NULL,
    data_envio DATETIME NOT NULL,
    lida BIT NOT NULL,
    FOREIGN KEY (chat_id) REFERENCES Chats(id_chat),
    FOREIGN KEY (remetente_id) REFERENCES Usuarios(id_usuario)
);

-- 20. TABELA PROFISSIONAL_CARGO
CREATE TABLE Profissional_Cargo (
    id_profissional INT NOT NULL,
    id_cargo INT NOT NULL,
    PRIMARY KEY (id_profissional, id_cargo),
    FOREIGN KEY (id_profissional) REFERENCES Profissionais(id_profissional),
    FOREIGN KEY (id_cargo) REFERENCES Cargos(id_cargo)
);