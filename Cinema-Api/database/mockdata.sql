INSERT INTO Genero
(nome)
VALUES
('Ação'),
('Aventura'),
('Fantasia'),
('Terror'),
('Drama'),
('Policial'),
('Mistério'),
('Histórico'),
('Comédia');


INSERT INTO Ator
(nome, dataNasc)
VALUES
('Robertozinho', '01/01/1990'),
('Afonso', '12/06/2003');


INSERT INTO Diretor
(nome, dataNasc, biografia)
VALUES
('Robertozão', '01/01/1989', 'Nasceu e viveu'),
('Afonsa', '12/06/2001', 'Gosta de gatos');


INSERT INTO Filme
(titulo, anoLancamento, sinopse, notaIMDB, diretorId)
VALUES
(
	'Turma do Juninho',
	2025,
	'O Juninho e sua turminha do barulho aprontam muitas trapalhadas nesse filme da pesada',
	0,
	1
),
(
	'Filme de Medo D:',
	2023,
	'Esse filme dá medo, hein',
	10,
	2
);


INSERT INTO FilmeAtor
(filmeId, atorId, papel)
VALUES
(1, 1, 'Juninho');


INSERT INTO FilmeGenero
(filmeId, generoId)
VALUES
(1, 9),
(2, 4);