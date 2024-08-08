select produtos.titulo, autores.nome from produtos
join autores_produtos
	on produtos.cod_produto = autores_produtos.cod_produto
join autores
	on autores.cod_autor = autores_produtos.cod_autor
order by produtos.titulo;

--quantos produtos na tabela
select 