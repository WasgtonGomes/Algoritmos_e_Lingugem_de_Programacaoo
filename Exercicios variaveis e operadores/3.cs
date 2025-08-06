float ht, vh, pd, sb, td, sl; 

escreva("Digite a quantidade de horas trabalhadas:");
leia(ht);

escreva("Digite o valor da hora trabalhada:");
leia(vh);

escreva("Digite o valor do percentual de desconto:");
leia(pd);

sb = (ht * vh);

td = ((pd/100)* sb);


sl= (sb - td);

escreva("As horas trabalhadas são: "+ ht );

escreva("O salário bruto é de: " + sb);

escreva("O valor do desconto é de: " + td);

escreva("O valor do salário liquido é de: "+ sl);