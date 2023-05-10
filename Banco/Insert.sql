INSERT INTO cliente (id, nome, telefone) OVERRIDING SYSTEM VALUE
VALUES
(1, 'Gabriel', '777-777'),
(2, 'Mariza', '888-888');

INSERT INTO funcionario (id, nome, data_contratado, salario) OVERRIDING SYSTEM VALUE
VALUES
(1, 'Ianko', '2023-01-06', 500),
(2, 'Luiz', '2023-05-14', 800);

INSERT INTO endereco (id, rua, complemento, numero, cep, cidade, estado, id_cliente) OVERRIDING SYSTEM VALUE
VALUES
(1, 'Sergio', 'Casa', '123456789', '12345678', 'jp', 'pb', 1),
(2, 'Rua Vermelha', 'Esquina', '987456321', '15978462', 'Franca', 'sp', 2);

INSERT INTO categoria (id, nome) OVERRIDING SYSTEM VALUE
VALUES
(1, 'Comédia'),
(2, 'Terror');

INSERT INTO filme (id, nome, sinopse, id_categoria) OVERRIDING SYSTEM VALUE
VALUES
(1, 'Harry Potter', 'Menino Bruxo', 1),
(2, 'Halloween', 'Mike Myers', 2);

INSERT INTO pedido (id, data_pedido, quantidade, preco, id_cliente, id_filme) OVERRIDING SYSTEM VALUE
VALUES
(1, '2023-12-05', 2, 25, 1,1),
(2, '2023-09-04', 3, 50, 2,2);