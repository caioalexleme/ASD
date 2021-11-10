#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main () {
    char nome[90];
    char opcao;
    printf("Digite seu nome: ");
    scanf(" %s ", &nome);
    printf("%s Deseja continuar? ", nome);
    scanf(" %c ", &opcao);
    if(opcao == "n"){
        printf("\nAté mais!!");
    }else{
        scanf(" %c ", &opcao);
    }



    system("PAUSE");
    return 0;
}
