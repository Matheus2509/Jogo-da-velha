int [,]jogo_da_Velha = new int [3,3];
int Coluna = 0, linha = 0, Jogador = 1, Resultado = 0;
//
//Mostrar primeiro jogo e criar jogo
//
Console.Clear();
for (int i = 0; i < 3;i++){

    Console.WriteLine("----------");
    for (int j = 0; j <3; j++){
        jogo_da_Velha[i,j] = 0;
        Console.Write("|"+jogo_da_Velha[i,j]+"|");
        if(i == 2 && j == 2){
            Console.WriteLine();
            Console.WriteLine("----------");
        }
    }
    Console.WriteLine();
}
//
//Jogo sendo executado
//
for(int i = 0; i < 10;)
    {
    int j = jogada(Coluna,linha,Jogador);
    Console.Clear();
    ver_jogo();
    if(veificar_ganhador())
    {
     Resultado = 1;
     break;
    }
    if(verificar_empate())
    {
     break;
    }
 //
 //Trocar jogador
 //
    jogada(Coluna,linha,j);
    Console.Clear();
    ver_jogo();
    if(veificar_ganhador())
    {
     Resultado = 2;
     break;
     }
    if(verificar_empate())
    {
     break;
    }
}

 //
 //Fim
 //
if(Resultado !=0){
    Console.WriteLine("O ganhador é o jogador: " + Resultado+"!!!!");
}
else{
    Console.WriteLine("Fim de jogo: Empate!!!!");
 }

Console.ReadLine();
//
//Metodos
//
bool ver_jogo()
{
 for (int i = 0; i < 3;i++)
    {
     Console.WriteLine("----------");
     for (int j = 0; j < 3; j++)
        {
         Console.Write("|"+jogo_da_Velha[i,j]+"|");
         if(i == 2 && j == 2)
            {
             Console.WriteLine();
             Console.WriteLine("----------");
            }
        }
     Console.WriteLine();
     
    }
    return true;
}
int jogada(int Coluna,int linha,int Jogador)
{
//
//Teste de validação de coluna e linha
//

 for(int i = 0; i < 1;)
    {
     Console.WriteLine("Vez do jogador: "+Jogador);
     Console.WriteLine("Por favor,insira uma linha: ");
     Coluna = Convert.ToInt32(Console.ReadLine()) -1;
     Console.WriteLine("Por favor,insira uma coluna: ");
     linha = Convert.ToInt32(Console.ReadLine()) -1;
     if(Coluna < 3 && linha < 3)
        {
        i = 1;
        }
     else
        {
         i = 0;
          Console.WriteLine("*********************************************************\nPor favor faça uma jogada valida!!!!!\n*********************************************************");
        }
    }

    if (jogo_da_Velha[Coluna,linha] == 0 ){
        jogo_da_Velha[Coluna, linha] = Jogador;
    }
    else {
        Console.WriteLine("*********************************************************\nPor favor faça uma jogada valida!!!!!\n*********************************************************");
        jogada(Coluna,linha,Jogador);
    }

    if (Jogador == 1){
        return 2;
    }
    else
    {
        return 1;
    }
    
}
bool veificar_ganhador()

{

 for(int i = 0; i < 3;i++)
    {
     if ((jogo_da_Velha[i,1]!=0) && jogo_da_Velha[i,0]== jogo_da_Velha[i,1] && jogo_da_Velha[i,1]== jogo_da_Velha[i,2])
        {
         return true;
        }
     if ((jogo_da_Velha[0,i]!=0) && jogo_da_Velha[0,i]== jogo_da_Velha[1,i] && jogo_da_Velha[1,i]== jogo_da_Velha[2,i])
        {
         return true;
        }
    }
 if ((jogo_da_Velha[1,1]!=0) && jogo_da_Velha[0,0]== jogo_da_Velha[1,1] && jogo_da_Velha[1,1]== jogo_da_Velha[2,2])
    {
     return true;
    }
 if ((jogo_da_Velha[1,1]!=0) && jogo_da_Velha[0,2] == jogo_da_Velha[1,1] && jogo_da_Velha[1,1] == jogo_da_Velha[2,0])
    {
     return true;
    }

 return false;
}
bool verificar_empate(){
 for(int i = 0; i < 3; i++)
    {
     for(int j = 0; j < 3; j++)
        {
         if(jogo_da_Velha[i,j] == 0)
            {
             return false;
            }
        }
    }
return true;
}