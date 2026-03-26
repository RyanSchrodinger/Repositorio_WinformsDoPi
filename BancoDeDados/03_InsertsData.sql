USE MusicStation;
GO

INSERT INTO Usuarios (nome, email, usuario_nome, senha, data_cadastro)
VALUES
('João Lima', 'joao@gmail.com', 'joao', 'hash123', '2025-10-10 08:15:23'),
('Maria Souza', 'maria@gmail.com', 'maria', 'hash234', '2025-10-10 09:42:10'),
('Lucas Reis', 'lucas@gmail.com', 'lucas', 'hash345', '2025-10-10 10:05:55'),
('Beatriz Silva', 'bia@gmail.com', 'bia', 'hash456', '2025-10-10 11:27:33'),
('Rafaela Gomes', 'rafa@gmail.com', 'rafa', 'hash567', '2025-10-10 13:12:47'),
('Guilherme Lopes', 'gui@gmail.com', 'gui', 'hash678', '2025-10-10 14:55:02'),
('Thiago Ramos', 'thiago@gmail.com', 'thiago', 'hash789', '2025-10-10 16:08:19'),
('Patrícia Alves', 'paty@gmail.com', 'paty', 'hash890', '2025-10-10 17:33:41'),
('Carlos Almeida', 'carlos@luthier.com', 'carlos', 'hash999', '2025-09-15 08:20:00'),
('Paulo Bezerra', 'paulo@tecnico.com', 'paulo', 'hash888', '2025-09-15 09:45:12'),
('Ana Paula', 'ana@musica.com', 'ana', 'hash777', '2025-09-15 11:10:35'),
('Music Station Studio', 'contato@musicstation.com', 'contato', 'hash001', '2025-08-01 08:00:00'),
('Admin Sistema', 'admin@musicstation.com', 'admin', 'hashadm', '2025-08-01 08:05:00'),
('Tiago Admin', 'tiago.admin@music.com', 'tiago.admin', 'hashadm2', '2025-10-01 12:30:45');

INSERT INTO Clientes (usuario_id, telefone, rua, numero)
VALUES
(1, '(11)99999-9999', 'Rua das Flores', '10'),
(2, '(11)97777-7777', 'Av. Brasil', '50'),
(3, '(11)95555-5555', 'Rua das Palmeiras', '55'),
(4, '(11)93333-3333', 'Av. das Nações', '200'),
(5, '(11)92222-2222', 'Rua Bela Vista', '75'),
(6, '(11)91111-1111', 'Av. Industrial', '15'),
(7, '(11)90000-0000', 'Rua Rio Branco', '90'),
(8, '(11)98877-6666', 'Av. Central', '120');

INSERT INTO Administradores(usuario_id, nivel_acesso, data_criacao, observacoes)
VALUES
(13, '10', '2025-08-01','Superadmin — acesso total'), 
(14, '5', '2025-10-01', 'Acesso a relatórios e suporte'); 

INSERT INTO Profissionais (usuario_id, telefone)
VALUES
(9, '(11)98888-8888'),
(10, '(11)96666-6666'),
(11, '(11)94444-4444');

INSERT INTO Formas_Pagamento (tipo)
VALUES
('Cartão'),
('Dinheiro'),
('Pix');

INSERT INTO Cargos (nome, descricao)
VALUES
('Luthier', 'Constrói, repara e mantém instrumentos de cordas.'),
('Técnico de Som', 'Monta e opera sistemas de áudio.'),
('Professor de Violão', 'Ensina técnicas, teoria e prática musical.');

INSERT INTO Servicos (nome, descricao, preco)
VALUES
('Conserto de Guitarra', 'Troca de cordas e regulagem', 150.00),
('Ajuste de Mesa de Som', 'Limpeza e calibração de canais', 200.00),
('Aula de Violão', 'Iniciação para iniciantes', 120.00),
('Troca de Cordas', 'Substituição de cordas antigas', 80.00),
('Manutenção de Amplificador', 'Troca de válvulas e limpeza', 250.00),
('Aula Avançada de Violão', 'Técnicas de solo e harmonia', 130.00),
('Regulagem de Baixo', 'Ajuste de ação e oitava', 180.00),
('Instalação de Sistema de Som', 'Montagem completa para eventos', 500.00);

INSERT INTO Pedidos (cliente_id, data_pedido, total, status)
VALUES
(1, '2025-11-12', 270.00, 'Concluído'),
(2, '2025-11-10', 200.00, 'Concluído'),
(3, '2025-11-08', 120.00, 'Em andamento'),
(4, '2025-11-05', 80.00, 'Concluído'),
(5, '2025-11-01', 250.00, 'Concluído'),
(6, '2025-11-02', 130.00, 'Concluído'),
(7, '2025-11-07', 180.00, 'Em andamento'),
(8, '2025-11-11', 500.00, 'Concluído');

INSERT INTO Chats (usuario1_id, usuario2_id, data_criacao)
VALUES
(1, 9, '2025-11-10 08:00:00'),
(2, 11, '2025-11-08 09:30:00'),
(3, 10, '2025-11-01 11:00:00');

INSERT INTO Notificacoes (usuario_id, titulo, mensagem, tipo, data_envio, lida)
VALUES
(1, 'Pagamento aprovado', 'Seu pagamento de R$270 foi confirmado.', 'sistema', '2025-11-12 09:00:00', 1),
(2, 'Serviço concluído', 'Seu pedido foi finalizado com sucesso.', 'sistema', '2025-11-10 10:00:00', 1),
(3, 'Novo agendamento', 'Seu serviço está em andamento.', 'agendamento', '2025-11-08 12:00:00', 0),
(4, 'Nova mensagem', 'Cliente enviou uma dúvida sobre o serviço.', 'mensagem', '2025-11-09 14:30:00', 0);

INSERT INTO Servicos_Pedidos (pedido_id, servico_id, profissional_id, valor_servico)
VALUES
(1, 1, 1, 150.00),
(1, 3, 3, 120.00),
(2, 2, 2, 200.00),
(3, 3, 3, 120.00),
(4, 4, 1, 80.00),
(5, 5, 2, 250.00),
(6, 6, 3, 130.00),
(7, 7, 1, 180.00),
(8, 8, 2, 500.00);

INSERT INTO Avaliacoes (servico_pedido_id, cliente_id, nota, comentario, data_avaliacao)
VALUES
(1, 1, 5, 'Serviço excelente!', '2025-11-12'),
(2, 2, 4, 'Bom atendimento!', '2025-11-10'),
(3, 3, 5, 'Excelente aula!', '2025-11-08'),
(4, 4, 5, 'Muito rápido!', '2025-11-05'),
(5, 5, 4, 'Som ficou ótimo!', '2025-11-01'),
(6, 6, 5, 'Serviço impecável!', '2025-11-02');

INSERT INTO Empresas (usuario_id, nome_fantasia, razao_social, cnpj, email, telefone, descricao, data_cadastro)
VALUES
(12, 'Music Station Studio', 'Music Station LTDA', '12.345.678/0001-90', 'contato@musicstation.com', '(11)99999-0000', 'Estúdio e loja de instrumentos musicais.', '2025-08-01');

INSERT INTO Instrumentos (empresa_id, nome, descricao, preco_locacao, disponivel)
VALUES
(1, 'Guitarra Fender Stratocaster', 'Modelo clássico, ótimo som limpo.', 120.00, 1),
(1, 'Baixo Yamaha TRBX', 'Timbre balanceado, ideal para estúdio.', 100.00, 1), 
(1, 'Teclado Roland', 'Equipamento profissional com várias oitavas.', 150.00, 1);

INSERT INTO Locacoes (cliente_id, data_inicio, data_fim, valor_total, status)
VALUES
(1, '2025-11-01', '2025-11-03', 240.00, 'concluída'),
(2, '2025-11-05', '2025-11-07', 200.00, 'concluída'),
(3, '2025-11-10', '2025-11-15', 750.00, 'ativa');

INSERT INTO Locacao_Itens (locacao_id, instrumento_id, preco_locacao, dias, subtotal)
VALUES 
(1, 1, 120.00, 2, 240.00),
(2, 2, 100.00, 2, 200.00),
(3, 3, 150.00, 5, 750.00);

INSERT INTO Pagamentos (pedido_id, forma_pagamento_id, data_pagamento, valor_pago, status)
VALUES
(1, 3, '2025-11-12', 270.00, 'aprovado'),
(2, 1, '2025-11-10', 200.00, 'aprovado'),
(3, 3, '2025-11-08', 120.00, 'pendente'),
(4, 3, '2025-11-05', 80.00, 'aprovado'),
(5, 1, '2025-11-01', 250.00, 'aprovado'),
(6, 3, '2025-11-02', 130.00, 'aprovado'),
(7, 3, '2025-11-07', 180.00, 'pendente'),
(8, 3, '2025-11-11', 500.00, 'aprovado');

INSERT INTO Transacoes_Pagamento (pagamento_id, status, codigo_externo, data_transacao)
VALUES
(1, 'aprovado', 'TXN001', '2025-11-12 10:32:00'),
(2, 'aprovado', 'TXN002', '2025-11-10 14:18:00'),
(3, 'processando', 'TXN003', '2025-11-08 09:50:00'),
(4, 'aprovado', 'TXN004', '2025-11-05 16:10:00'),
(5, 'aprovado', 'TXN005', '2025-11-01 11:45:00'),
(6, 'aprovado', 'TXN006', '2025-11-02 19:20:00'),
(8, 'aprovado', 'TXN007', '2025-11-11 19:20:00');

INSERT INTO Mensagens (chat_id, remetente_id, conteudo, data_envio, lida)
VALUES
(1, 1, 'Olá, preciso de conserto rápido.', '2025-11-10 08:05:00', 1),
(1, 9, 'Claro, posso agendar para amanhã.', '2025-11-10 08:06:00', 1),
(2, 3, 'Quando posso ter aula de violão?', '2025-11-08 09:31:00', 0),
(3, 10, 'A manutenção ficou pronta!', '2025-11-01 12:10:00', 1);

INSERT INTO Profissional_Cargo (id_profissional, id_cargo)
VALUES
(1, 1),
(2, 2),
(3, 3);