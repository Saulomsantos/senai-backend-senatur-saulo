USE SENATUR_MANHA;

INSERT INTO USUARIOS(Email, Senha, TipoUsuario)
VALUES			   ('admin@admin.com','admin','ADMINISTRADOR')
				  ,('cliente@cliente.com','cliente','CLIENTE');

INSERT INTO PACOTES(NomePacote, Descricao, DataIda, DataVolta, Valor, Ativo, NomeCidade)
VALUES			   ('SALVADOR - 5 DIAS / 4 DIÁRIAS'
				   ,'O que não falta em Salvador são atrações. Prova disso são as praias, os museus e as construções seculares que dão um charme mais que especial à região. A cidade, sinônimo de alegria, também é conhecida pela efervescência cultural que a credenciou como um dos destinos mais procurados por turistas brasileiros e estrangeiros. O Pelourinho e o Elevador são alguns dos principais pontos de visitação.'
				   ,'2019-08-06'
				   ,'2019-08-10'
				   ,854
				   ,1
				   ,'Salvador')

				   ,('RESORTS NA BAHIA - LITORAL NORTE - 5 DIAS / 4 DIÁRIAS'
				   ,'O Litoral Norte da Bahia conta com inúmeras praias emolduradas por coqueiros, além de piscinas naturais de águas mornas que são protegidas por recifes e habitadas por peixes coloridos. Banhos de mar em águas calmas ou agitadas, mergulho com snorkel, caminhada pela orla e calçadões, passeios de bicicleta, pontos turísticos históricos, interação com animais e até baladas estão entre as atrações da região. Destacam-se as praias de Guarajuba, Imbassaí, Praia do Forte e Costa do Sauípe.'
				   ,'2019-05-14'
				   ,'2019-05-18'
				   ,1826
				   ,1
				   ,'Salvador');