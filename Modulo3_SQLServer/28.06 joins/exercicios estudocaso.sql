--EC1
select count(en.cod_endereco), est.nome 
from enderecos en 
	inner join cidades cid on en.cod_cidade = cid.cod_cidade
	inner join estados est on cid.uf = est.uf
group by (est.nome);

--EC2
select count(cli.cod_cliente), est.nome
from clientes cli 
inner join clientes_enderecos cli_end 
	on cli.cod_cliente = cli_end.cod_cliente
inner join enderecos en 
	on cli_end.cod_endereco = en.cod_endereco
inner join cidades cid
	on en.cod_cidade = cid.cod_cidade
inner join estados est
	on cid.uf = est.uf
group by (est.nome);

--EC3
select count(cli.cod_cliente) as qtdadeCliente, est.nome
from clientes cli 
inner join clientes_enderecos cli_end 
	on cli.cod_cliente = cli_end.cod_cliente
inner join enderecos en 
	on cli_end.cod_endereco = en.cod_endereco
inner join cidades cid
	on en.cod_cidade = cid.cod_cidade
inner join estados est
	on cid.uf = est.uf
group by (est.nome) order by qtdadeCliente desc;

--EC4
select count(cli.cod_cliente) as qtdadeCliente, est.regiao
from clientes cli 
inner join clientes_enderecos cli_end 
	on cli.cod_cliente = cli_end.cod_cliente
inner join enderecos en 
	on cli_end.cod_endereco = en.cod_endereco
inner join cidades cid
	on en.cod_cidade = cid.cod_cidade
inner join estados est
	on cid.uf = est.uf
group by (est.regiao) order by qtdadeCliente desc;

--EC5
select count(ped.num_pedido) as qtdadePedidos, est.regiao
from pedidos ped
inner join clientes_enderecos cli_end 
		on ped.cod_endereco = cli_end.cod_endereco
inner join enderecos en 
		on cli_end.cod_endereco = en.cod_endereco
inner join cidades cid
		on en.cod_cidade = cid.cod_cidade
inner join estados est
		on cid.uf = est.uf
group by (est.regiao);

--EC6
