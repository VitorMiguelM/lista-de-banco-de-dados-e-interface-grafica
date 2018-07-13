DROP TABLE caracteristicas_do_aluno;
CREATE TABLE caracteristicas_do_aluno(
	nome VARCHAR(100) NOT NULL,
	codigo_de_matricula VARCHAR(100) NOT NULL,
	nota_1 FLOAT NOT NULL,
	nota_2 FLOAT NOT NULL,
	nota_3 FLOAT NOT NULL,
	frequencia TINYINT NOT NULL,
	id INT IDENTITY(1,1)
);