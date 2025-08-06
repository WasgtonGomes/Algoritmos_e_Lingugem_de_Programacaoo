int idade;

escreva("Digite a sua idade para consultar sua categoria de natação ");
leia(idade);

se ((idade>=5)&&(idade<=7))
{
	escreva("Sua categoria é infantil A  ");
}

senao 
{
	se ((idade>=8)&&(idade<=10))
	{
		escreva("Sua categoria é infantil B ");
	}
	
	senao 
	{
		se ((idade>=11)&&(idade<=13))
		{
			escreva("Sua categoria é juventil A ");
		}
	
		senao 
		{
			se ((idade>=14)&&(idade<=17))
			{
				escreva("Sua categoria é juventil B ");
			}
	
			senao 
			{
					se ((idade>=18))
					{
						escreva("Sua categoria é Sênior");
					}
	
					senao 
					{
						escreva("Você não possui idede suficiente para uma categoria de natação!!");
					}
			}
		}
	
	
	
	
	
	
	
	}
}