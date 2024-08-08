------------------------------------
-- Prof. Daniel Callegari
-- Escola Politecnica - PUCRS
------------------------------------

CREATE TABLE Funcionarios (
  Cod NUMBER(2) PRIMARY KEY,
  Nome Varchar(30) NOT NULL,
  Sexo Char(1),
  Depto Varchar(15),
  Salario Number(10,2)
)

INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (10,'Joao'  ,'M','Compras'  ,1000.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (12,'Maria'  ,'F','Vendas'  , 970.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (35,'Pedro'  ,'M','Expedicao', 800.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (08,'Ana'    ,'F','Expedicao', 790.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (37,'Carlos' ,'M','Vendas'  ,2090.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (47,'Marco'  ,'M','Compras'  ,1970.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (18,'Tiago'  ,'M','Expedicao', 700.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (32,'Lucas'  ,'M','Vendas'  ,4820.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (09,'Claudia','F','Vendas'  ,2220.00);
INSERT INTO Funcionarios (Cod, Nome, Sexo, Depto, Salario) VALUES (15,'Joana'  ,'F','Compras'  , 770.00);


-- QUESTAO A. Escreva os SELECTs --

-- 1. Quantidade de Funcion�rios por Departamento
-- 2. Que departamentos tem m�dia salarial maior que R$ 1000?
-- 3. M�dia sal�rial dos funcion�rios por sexo do setor de Compras
-- 4. O maior sal�rio do departamento que possui pelo menos duas pessoas
-- 5. N�mero de pessoas por sexo, por departamento
-- 6. Qual o total da folha de pagamento de cada departamento?
-- 7. Soma dos sal�rios dos Departamentos com mais de 1 funcion�rio


-- QUESTAO B. Modifique o Esquema --
-- 1. Exporte a coluna de departamento para outra tabela (crie codigo e descri��o).
-- 2. Refa�a as consultas anteriores usando joins quando for necess�rio
-- 3. Crie uma nova tabela (� sua escolha) e crie pelo menos 3 SELECTs que contenham fun��es de agrega��o e/ou group by.

-- Registre suas respostas no f�rum.



