USE SENATUR_MANHA;

SELECT 
	PacoteId,
	NomePacote,
	Descricao,
	CONVERT(varchar, DataIda, 110) AS DataIda,
	CONVERT(varchar, DataIda, 110) AS DataVolta,
	Valor,
	Ativo,
	NomeCidade 
FROM PACOTES;

SELECT
	UsuarioId,
	Email,
	Senha,
	TipoUsuario 
FROM USUARIOS;