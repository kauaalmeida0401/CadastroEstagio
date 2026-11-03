create database db_estagio;
use db_estagio;


CREATE TABLE IF NOT EXISTS candidato (
    Id INT AUTO_INCREMENT,
    Nome VARCHAR(150) NOT NULL,
    data_nascimento DATE NOT NULL,
    area_atuacao VARCHAR(50) NOT NULL,
    Matutino TINYINT(1) NOT NULL DEFAULT 0,
    Vespertino TINYINT(1) NOT NULL DEFAULT 0,
    Notturno TINYINT(1) NOT NULL DEFAULT 0,
    Escolaridade VARCHAR(100) NOT NULL,
    PRIMARY KEY (Id)
);	
select * from candidato;
use db_estagio;
ALTER TABLE candidato CHANGE COLUMN Notturno Noturno TINYINT(1) NOT NULL DEFAULT 0;