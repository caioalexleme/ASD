#include <stdio.h>
#include <stdlib.h>

int main(){
	int *pi;
	int i;
	pi=(int *) malloc(sizeof(int));
	for(i=0;i<3;i++){
	
	puts("Digite um numero : ");
	scanf("%d", pi);
	printf("\nVoce digitou o numero %d\n", *pi);
	free(pi);
	}
	printf("\n");
	printf("\n");
	system("PAUSE");
	return 0;
}
