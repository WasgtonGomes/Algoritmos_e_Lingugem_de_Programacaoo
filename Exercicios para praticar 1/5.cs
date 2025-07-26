

float tempo, distancia, velo_media, distancia, litros_usados;

escreva( "Digite o empo gasto na viagem:");
leia(tempo);

escreva("Digite a velocidade média do carro durante a viagem: ");
leia(velo_media);

distancia = (tempo * velo_media) ;

litros_usados = (distancia / 12);  

escreva("A velocidade média na viagem foi de " + velo_media + " K/h");

escreva("O tempo gasto na viagem foi de: " + tempo + " Horas" );

escreva("A distancia percorrida na viagem foi de: " + distancia + " K" );

escreva("A quantidade de litros utilizada na viagem foi de: " + litros_usados + " litros" );


