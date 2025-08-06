// Algoritimo para verificação de maior número

{
int A, B, C, Maior;

escreva("Escreva um valor para A: ");
leia(A);

escreva("Escreva um valor para B: ");
leia(B);

escreva("Escreva um valor para C: ");
leia(C);

if ((A>=B) && (A>=C))
{
	Maior= A;
}
else
{
	if (B>=C)
	{
		Maior= B;
	}
	else
	{
		maior= C;
	}

}

escreva("O maior número digitatado é "+ Maior);
}