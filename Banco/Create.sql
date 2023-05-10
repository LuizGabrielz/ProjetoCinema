create table cliente (
id INT GENERATED ALWAYS AS IDENTITY,
nome VARCHAR(60) NOT NULL,
telefone CHAR(12) NOT NULL,
 	CONSTRAINT pk_cliente_id PRIMARY KEY (id)
);

create table funcionario (
id INT GENERATED ALWAYS AS IDENTITY,
nome VARCHAR(60) NOT NULL,
data_contratado DATE NOT NULL,
salario DECIMAL(6,2) NOT NULL,
	CONSTRAINT pk_funcionario_id PRIMARY KEY (id)
);

create table endereco (
id INT GENERATED ALWAYS AS IDENTITY,
rua VARCHAR(120) NOT NULL,
numero VARCHAR(20) NOT NULL,
complemento VARCHAR(120),
cep CHAR(8) NOT NULL,
cidade VARCHAR(60) NOT NULL,
estado CHAR(2) NOT NULL,
	id_cliente INT NOT NULL,
	CONSTRAINT pk_endereco_id PRIMARY KEY (id),
	CONSTRAINT fk_cliente FOREIGN KEY (id_cliente) REFERENCES cliente (id)
);

create table categoria (
id INT GENERATED ALWAYS AS IDENTITY,
nome VARCHAR(60) NOT NULL,
	CONSTRAINT pk_categoria_id PRIMARY KEY (id)
);

create table filme (
id INT GENERATED ALWAYS AS IDENTITY,
nome VARCHAR(60) NOT NULL,
sinopse VARCHAR(400) NOT NULL,
	id_categoria INT NOT NULL,
	CONSTRAINT pk_filme_id PRIMARY KEY (id),
	CONSTRAINT fk_categoria FOREIGN KEY (id_categoria) REFERENCES categoria (id)
);

create table pedido (
id INT GENERATED ALWAYS AS IDENTITY,
data_pedido DATE NOT NULL,
quantidade INT NOT NULL,
preco DECIMAL(6,2) NOT NULL,
   	id_cliente INT NOT NULL,
	id_filme INT NOT NULL,
	CONSTRAINT pk_pedido_id PRIMARY KEY (id),
	CONSTRAINT fk_cliente FOREIGN KEY (id_cliente) REFERENCES cliente (id),
	CONSTRAINT fk_filme FOREIGN KEY (id_filme) REFERENCES filme (id)
);