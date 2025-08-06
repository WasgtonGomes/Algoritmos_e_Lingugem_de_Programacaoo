int cod, quant;
float valor_unitario, preco_total;

escreva("Digite o código do produto: ");
leia(cod);

escreva("Digite a quantiade de produtos: ");
leia(quant);

se (cod==1001)
{
	valor_unitario = 5.32;
}
senao 
{
	se (cod==1324)
	{
		valor_unitario = 6.45;
	}
	senao 
	{
		se (cod==6548)
		{
			valor_unitario = 2.37;
		}
		senao 
		{
			se (cod==0987)
			{
				valor_unitario = 4.26;
			}
			senao 
			{
			}
		}
	}
}

preco_total = (valor_unitario * quant );

escreva("O valor total é de: R$ "+ preco_total);