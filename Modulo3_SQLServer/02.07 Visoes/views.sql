select * from produtos;

create view PRODUTOS_IMPORTADOS as
	select cod_produto, titulo, preco
	from produtos
	where importado = 'S';

select * from PRODUTOS_IMPORTADOS;

select cod_produto, titulo, round(preco / 5.7, 2) as USD
from PRODUTOS_IMPORTADOS;