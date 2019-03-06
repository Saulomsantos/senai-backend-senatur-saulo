CREATE DATABASE SENATUR_MANHA;

USE SENATUR_MANHA;

CREATE TABLE PACOTES(
	PacoteId INT IDENTITY PRIMARY KEY
	,NomePacote VARCHAR(150) UNIQUE NOT NULL
	,Descricao TEXT NOT NULL
	,DataIda DATE NOT NULL
	,DataVolta DATE NOT NULL
	,Valor DECIMAL(10,2) NOT NULL
	,Ativo BIT NOT NULL
	,NomeCidade VARCHAR(150) NOT NULL
);

CREATE TABLE USUARIOS(
	UsuarioId INT IDENTITY PRIMARY KEY
	,Email VARCHAR(250) UNIQUE NOT NULL
	,Senha VARCHAR(250) NOT NULL
	,TipoUsuario VARCHAR(250) NOT NULL
);