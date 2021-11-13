#include <stdio.h>
#include <stdlib.h>

int main() {

    int numero;
    printf("Digite um numero: \n");
    scanf("%d", &numero);
    getchar();      // Limpa o buffer do teclado do PC 
    printf("\n  %d\n\n", numero);
    system("PAUSE");
    return 0;
}
