#include <stdio.h>
#include <stdlib.h>

void main(){
FILE *Ponteiro;
Ponteiro=fopen("arquivo.txt", "a");
fclose(Ponteiro);
system("PAUSE");
}
