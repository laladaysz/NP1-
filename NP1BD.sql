create database parking_lot;

use parking_lot;
drop database parking_lot;

CREATE TABLE Usuario (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Ativado BOOLEAN NOT NULL
);

CREATE TABLE Motorista (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    Email VARCHAR(200) NOT NULL,
    Telefone VARCHAR(15),
    Ativo BOOLEAN DEFAULT TRUE
);

CREATE TABLE Veiculo (
    Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Placa varchar(60),
    Modelo varchar(60),
    Cor varchar(60),
    MotoristaId INT,

    FOREIGN KEY (MotoristaId) REFERENCES Motorista(Id)
);

CREATE TABLE Vaga (
	Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Numero varchar(60),
    Tipo varchar(60),
    Disponivel BOOLEAN NOT NULL,
    Localizacao varchar(100)
);

CREATE TABLE EntradasSaidas (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    VeiculoId INT NOT NULL,
    VagaId INT NOT NULL,
    MotoristaId INT NOT NULL,
    Entrada DATETIME NOT NULL,
    Saida DATETIME NULL,
    Pago BOOLEAN NOT NULL DEFAULT 0,
    FOREIGN KEY (VeiculoId) REFERENCES Veiculo(Id),
    FOREIGN KEY (VagaId) REFERENCES Vaga(Id),
    FOREIGN KEY (MotoristaId) REFERENCES Motorista(Id)
);


INSERT INTO Usuario VALUES (1, "Laura", "lala", "123", "ADMIN", true);

INSERT INTO Motorista VALUES (1, "Laura", "lala", "19981906123", 1, true);

INSERT INTO Usuario VALUES (1, "Laura", "lala", "123", "ADMIN", true);

update Usuario set ativado = true where id = 1;

SELECT Nome FROM Motorista WHERE Id = 1;

SELECT * FROM Veiculo;

DESCRIBE Motorista;

SELECT * FROM Vaga;
