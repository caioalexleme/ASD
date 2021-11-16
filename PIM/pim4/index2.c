#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<locale.h>
#include<string.h>
#include<time.h>
#define SIZE 200

int cadastro();
int pesquisa();
int lista();
int login();

struct CADASTRO{
char nome[50];
char cpf[12];
char email[20];
char fone[15];
char rua[40];
char numero[10];
char cidade[30];
char estado[20];
char cep[9];
int nascimento;
char comorbidade[20];
int data;
int ano;
int mes;
int dia;
int hora;
int minutos;
int segundos;

}add[200];

int op;
int linha=0;


struct{

    char nome[50];
    char login[20];
    char senha[16];
} usuarios[10];


int i;



int main (){

    system("color 8F");
    setlocale(LC_ALL,"portuguese");

    strcpy(usuarios[0].nome, "admin");
    strcpy(usuarios[0].login, "admin");
    strcpy(usuarios[0].senha, "1234");
    while(login()==0);

    do{
       system("cls");

       printf("\t\t-------------MENU PRINCIPAL--------------\t\t");
       printf("\t\n-------------------------------------------------------------------\t\n");

       printf("\t\n#--------------------------------------------#\t\n");
       printf("\t\n|1 - CADASTRAR                               |\t\n");
       printf("\t\n|2 - PESQUISAR POR PACIENTES CADASTRADOS     |\t\n");
       printf("\t\n|3 - LISTA DE PACIENTES                      |\t\n");
       printf("\t\n|4 - SAIR                                    |\t\n");
       printf("\t\n#--------------------------------------------#\t\n");
       printf("\t\n Selecione a opção desejada: ");
       op=getch();

            switch(op){

            case '1':
                cadastro();

                break;

            case '2':
                pesquisa();

                break;


            case '3':
                lista();

                break;

            case '4':

                break;


            default:
                printf("Opção Inválida!\n");
                break;

            }


    }while(op!='4');


    system("cls");
    printf("\t\t\t OBRIGADO POR UTILIZAR NOSSO PROGRAMA!!! \n");

system("pause");
}


int cadastro(){


    do{
        system("cls");
        printf("\t\t----------CADASTRAMENTO DE PACIENTES--------\t\n");
        printf("\t\t|------------------------------------------|\n\n");

        fflush(stdin);
        printf("Nome: ");
        gets(add[linha].nome);
        fflush(stdin);
        printf("CPF: ");
        gets(add[linha].cpf);
        fflush(stdin);
        printf("Email: ");
        gets(add[linha].email);
        fflush(stdin);
        printf("Telefone: ");
        gets(add[linha].fone);
        fflush(stdin);
        printf("Rua e Bairro: ");
        gets(add[linha].rua);
        fflush(stdin);
        printf("Número: ");
        gets(add[linha].numero);
        fflush(stdin);
        printf("Cidade: ");
        gets(add[linha].cidade);
        fflush(stdin);
        printf("Estado: ");
        gets(add[linha].estado);
        fflush(stdin);
        printf("CEP: ");
        gets(add[linha].cep);
        fflush(stdin);
        printf("Data de Nascimento: ");
        scanf("%d", &add[linha].nascimento);
        fflush(stdin);
        printf("Comorbidade: ");
        gets(add[linha].comorbidade);
        fflush(stdin);
        struct tm *data_hora_atual;
        time_t segundos;
        time(&segundos);
        data_hora_atual = localtime(&segundos);
        printf("Hora ........: %d:",data_hora_atual->tm_hour);
        printf("%d:",data_hora_atual->tm_min);
        printf("%d",data_hora_atual->tm_sec);
        printf("\nData ........: %d/", data_hora_atual->tm_mday);
        printf("%d/",data_hora_atual->tm_mon+1);
        printf("%d\n",data_hora_atual->tm_year+1900);
        printf("\n\n");

        printf("-------------------------------\n");
        printf("1 - Novo Cadastro   \n");
        printf("2 - Voltar ao menu principal  \n");
        printf("-------------------------------\n");
        printf("Opção Escolhida: ");
        scanf("%d", &op);

        ++linha;
        system("cls");





    }while(op == 1);

 return 0;

}

int pesquisa(){

    char pesquisacpf[50];
    char pesquisaemail[50];
    int i;

    do{
        system("cls");
        printf("\t\t--------PESQUISA DE CADASTROS-------\t\n");
        printf("\t\t------------------------------------\n\n");

        printf("1 - Pesquisar por CPF\n");
        printf("2 - Pesquisar por Email\n\n");
        printf("Opção desejada: ");
        scanf("%d", &op);
        system("cls");
            switch(op){

            case 1:
                system("cls");
                printf("\t\t-------PESQUISA POR CPF-------\t\n");
                printf("\t\t------------------------------\n\n");

                fflush(stdin);
                printf("Por favor, digite o CPF desejado: ");
                gets(pesquisacpf);
                printf("\n\n");

                printf("--RESULTADO DA PESQUISA--\n");
                printf("-------------------------\n\n");

                for(i=0; i<linha; ++i){
                    if(strcmp(add[i].cpf,pesquisacpf)==0){
                printf("------------------------------------\n");
                printf("Nome: %s\n", add[i].nome);
                printf("Email: %s\n",add[i].email);
                printf("CPF: %s\n", add[i].cpf);
                printf("-------------------------------------\n");
                printf("\n\n");
                system("pause");



                    }
                }

                break;

            case 2:

                system("cls");
                printf("\t\t--------PESQUISA POR EMAIL--------\t\n");
                printf("\t\t-----------------------------------\n\n");

                printf("Por favor, digite o Email desejado: ");
                scanf("%s",pesquisaemail);
                printf("\n\n");

                printf("--RESULTADO DA PESQUISA--\n");
                printf("-------------------------\n\n");

                for(i=0; i<SIZE; ++i){
                    if (strcmp(add[i].email, pesquisaemail)==0){


                    }
                }

                break;
            default:
                printf("Opção Inválida!");

                break;

            }
            printf("--------------------------------\n");
            printf("1 - Continuar a pesquisa         |\n");
            printf("2 - Voltar ao menu principal     |\n");
            printf("--------------------------------\n");
            printf("Selecione a opção desejada: ");
            scanf("%d", &op);
    }while(op == 1);

    return 0;


}

int lista(){

     char grupoderisco[50];
     char gruposemrisco[50];
     char grupocomorbidade[50];
     int i;


    system("cls");
    printf("\t\t---------GRUPO DE PACIENTES CADASTRADOS NO SISTEMA-------\t\n");
    printf("\t\t|-------------------------------------------------------|\n\n");

        printf("1 - Grupo de Risco\n");
        printf("2 - Grupo Sem Risco\n");
        printf("3 - Grupo Com Comorbidade\n");
        printf("Opção desejada: ");
        scanf("%d", &op);
        system("cls");

        switch(op){

            case 1:
                system("cls");
                printf("\t\t-------GRUPO DE RISCO-------\t\n");
                printf("\t\t------------------------------\n\n");

        for(i=0; i<linha; ++i){

         printf("------------------------------------\n");
         printf("Nome: %s\n", add[i].nome);
         printf("CPF: %s\n", add[i].cpf);
         printf("Email: %s\n",add[i].email);
         printf("Fone: %s\n", add[i].fone);
         printf("Rua: %s\n", add[i].rua);
         printf("Número: %s\n", add[i].numero);
         printf("Cidade: %s\n", add[i].cidade);
         printf("Estado: %s\n", add[i].estado);
         printf("CEP: %s\n", add[i].cep);
         printf("Nascimento: %d\n", add[i].nascimento);

         printf("-------------------------------------\n");
         printf("\n\n");
         system("pause");

    }

        break;

        case 2:

                system("cls");
                printf("\t\t--------GRUPO SEM RISCO--------\t\n");
                printf("\t\t-----------------------------------\n\n");

                break;


        case 3:

                system("cls");
                printf("\t\t--------GRUPO SEM RISCO--------\t\n");
                printf("\t\t-----------------------------------\n\n");

                break;

        }

            printf("--------------------------------\n");
            printf("1 - Continuar a pesquisa         |\n");
            printf("2 - Voltar ao menu principal     |\n");
            printf("--------------------------------\n");
            printf("Selecione a opção desejada: ");
           scanf("%d", &op);


    return 0;
}


int login (){

    system("cls");

    char login[20], senha[16];
    int i=0;

    printf("\t\t------LOGIN DO PROGRAMA------\t\t");
    printf("\t\n------------------------------------------------------------\t\n");
    printf("\t\n------------------------------------------------------------\t\n");

    printf("\t LOGIN: ");
    gets(login);
    printf("\n\t SENHA: ");
    gets(senha);



            if(strcmp(usuarios[i].login, login)==0 && strcmp(usuarios[i].senha, senha)==0){
             return 1;
        main();


            }

        else{



        printf("\n\n");
        printf("---------------------------------------------\n");
        printf("| Login incorreto!\7\7 Por favor, tente novamente. |\n");
        printf("---------------------------------------------\n\n");

        }

        system("pause");

        return 0;
}