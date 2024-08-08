create table veiculos
(
    placa char(8),
    ano numeric(4),
    km numeric(6),
    marca varchar(50),
    modelo varchar(50)
);

--possivel validar com expressoes regulares

insert into veiculos values('IJK-1212', 2012, 0, 'Chevrolet', 'Vectra');
insert into veiculos values('IJM-1556', 2001, 72045, 'Volkswagen', 'Gol');
insert into veiculos (ano, placa, km, marca, modelo) values(2024, 'ABC-1010', 0, 'Volkswagen', 'Jetta');

insert into veiculos(km, marca, modelo, placa, ano) values (5000, 'Renault', 'Kwid', 'MDS-1111', 2015);

insert into veiculos (placa, ano, km, marca, modelo)
values ('JMA-0426', 2022, 02214, 'Nissan', 'March');

insert into veiculos (ano, placa, km, marca, modelo)
values (2020, 'JBL-2G89', 10000, 'Toyota', 'Yaris');

INSERT INTO VEICULOS (ano, placa, km, marca, modelo)
VALUES (2022, 'DEF-5050', 5000, 'Honda', 'Civic');

INSERT INTO VEICULOS (ano, placa, km, marca, modelo)
VALUES (2023, 'XYZ-2020', 15000, 'Toyota', 'Corolla');

insert into veiculos (ano, placa, km, marca, modelo)
values(1965, 'ILJ-3050', 50430, 'Volkswagen', 'Fusca');

INSERT INTO VEICULOS (placa, ano, km, marca, modelo)
VALUES ('ICB-7433', 2023, 11534, 'Porsche', '911 Dakar');

insert into veiculos(ano, placa, km, marca, modelo)
	values (2011, 'qlq-3536', 12000, 'fiat', 'uninho');

select * from veiculos;

select placa, ano
from veiculos
where km = 0;

select modelo, placa, ano
from veiculos
where (ano<2000) AND (marca='Volkswagen');

update veiculos
set modelo = 'Vectra Elite 2.0'
where placa = 'IJK-1212';

-- update veiculosa
-- set km = 0;
-- rollback;

update veiculos
set km = km + 1
where (marca = 'Volkswagen') AND (km > 10)

select * from veiculos