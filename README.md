Para realização dos testes é necessário a execução das querys a seguir:
Criação da tabela:
CREATE TABLE package(
packageId SERIAL PRIMARY KEY,
code VARCHAR(50) NOT NULL,
country VARCHAR(2) NOT NULL,
description VARCHAR(256) NOT NULL
);
