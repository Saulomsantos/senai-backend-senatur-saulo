USE SENATUR_MANHA;

INSERT INTO USUARIOS(Email, Senha, TipoUsuario)
VALUES			   ('admin@admin.com','admin','ADMINISTRADOR')
				  ,('cliente@cliente.com','cliente','CLIENTE');

INSERT INTO PACOTES(NomePacote, Descricao, DataIda, DataVolta, Valor, Ativo, NomeCidade)
VALUES			   ('SALVADOR - 5 DIAS / 4 DI�RIAS'
				   ,'O que n�o falta em Salvador s�o atra��es. Prova disso s�o as praias, os museus e as constru��es seculares que d�o um charme mais que especial � regi�o. A cidade, sin�nimo de alegria, tamb�m � conhecida pela efervesc�ncia cultural que a credenciou como um dos destinos mais procurados por turistas brasileiros e estrangeiros. O Pelourinho e o Elevador s�o alguns dos principais pontos de visita��o.'
				   ,'2019-08-06'
				   ,'2019-08-10'
				   ,854
				   ,1
				   ,'Salvador')

				   ,('RESORTS NA BAHIA - LITORAL NORTE - 5 DIAS / 4 DI�RIAS'
				   ,'O Litoral Norte da Bahia conta com in�meras praias emolduradas por coqueiros, al�m de piscinas naturais de �guas mornas que s�o protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em �guas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e cal�ad�es, passeios de bicicleta, pontos tur�sticos hist�ricos, intera��o com animais e at� baladas est�o entre as atra��es da regi�o. Destacam-se as praias de Guarajuba, Imbassa�, Praia do Forte e Costa do Sau�pe.'
				   ,'2019-05-14'
				   ,'2019-05-18'
				   ,1826
				   ,1
				   ,'Salvador');