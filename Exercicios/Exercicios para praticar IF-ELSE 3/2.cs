int a, b, c;

escreva("Informe o 1º número ");
leia(a);
escreva("Informe o 2º número ");
leia(b);
escreva("Informe o 3º número ");
leia(c);

if ((a<=b) && (a<=c))
{
	if (b<=c)
	{
		escreva("Os números em orfdem crescente é "+ a +", "+b+" e "+c);
	}
		else
		{
			escreva("Os números em orfdem crescente é "+ a +", "+b+" e "+c);

		}
}
	else
	{
		if ((b<=a) && (b<=c))
		{
			if (a<=c)
			{
				escreva("Os números em orfdem crescente é "+ b +", "+a+" e "+c);
			}
			else
			{
				escreva("Os números em orfdem crescente é "+ b +", "+c+" e "+a);
			}
		}
			else
			{
				if ((c<=a) && (c<=b))
				{
					if (a<=b)
					{
						escreva("Os números em orfdem crescente é "+ c +", "+a+" e "+b);
					}
						else
						{
							escreva("Os números em orfdem crescente é "+ c +", "+b+" e "+a);
						}
				}
					else
					{
			
					}
			}
	}
