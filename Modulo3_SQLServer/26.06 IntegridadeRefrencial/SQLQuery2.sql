CREATE TABLE ESTADOS
(
    uf CHAR(2) NOT NULL,
    nome VARCHAR(40) NOT NULL,
    regiao CHAR(2) NOT NULL,
    CONSTRAINT PK_ESTADOS PRIMARY KEY (uf)
);
insert into estados (uf, nome, regiao)
values ('RS', 'Rio Grande do Sul', 'S');
insert into estados (uf, nome, regiao)
values ('SC', 'Santa Catarina', 'S');

CREATE TABLE CIDADES
(
 cod_cidade NUMERIC(4) NOT NULL,
 nome VARCHAR(60) NOT NULL,
 uf CHAR(2) NOT NULL,
 CONSTRAINT PK_CIDADES PRIMARY KEY (cod_cidade)
);insert into cidades (cod_cidade, nome, uf)
values (10, 'Porto Alegre', 'RS');
insert into cidades (cod_cidade, nome, uf)
values (11, 'Canoas', 'RS');
insert into cidades (cod_cidade, nome, uf)
values (21, 'Florianopolis', 'SC');

select * from estados;
select * from cidades;


--cidades órfãs nao podem ser criadas só possivel deletar se:
-- ON DELETE/UPDATE CASCADE (cascata)
alter table cidades
add constraint fk_cid_est
	foreign key (uf) references estados(uf);

select * from estados,cidades;

select * from estados,cidades where estados.uf = CIDADES.uf;

select * from estados est
inner join cidades cid on est.uf = cid.uf
where est.uf = 'RS';