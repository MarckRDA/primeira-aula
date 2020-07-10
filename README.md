# Projeto Entra21

### Escrevendo e lendo do console:

    //Escrevendo:
    Console.WriteLine(texto);
    
    //Lendo:
    Console.ReadLine();

### Declarando variáveis e constantes
    var text = "meu texto";
    string text = "meu texto";
    const string text = "meu texto";

### Tipos básicos:
    // Tipo numérico
    var number = 1;
    
    //Tipo texto/string
    var text = "meu texto";
    
    //Tipo booleano/bool
    var boolean = true;

    //Tipo numérico com ponto flutuante/double:
    var price = 4.099;

    //Tipo Data/DateTime
    var currentDate = DateTime.Now;
 
### Parsers/ Transformadores
    
    // Transformar um texto/string em um número/int:
    var userAge = Int32.Parse(result);

### Operadores de matemática:
   
    // Somar:
    1 + 1;    
    
    // Subtrair:
    1 - 1;
       
    // Dividir:
    2 / 1;
    
    // Multiplicar:
    1 * 2;

    // Resto:
    1 % 2;
    // vai retornar 1

## Operadores de comparação 

### (toda comparação retorna um booleano/bool)
   
    // É igual?
    1 == 1;
    // Vai retornar true

    // É diferente?
    1 != 1;
    // Vai retornar false
   
    // É diferente?
    !(1 == 1)
    // Vai retornar false

    // Booleano da esquerda é true e o da direita também?
    true && true;
    // vai retornar true

    // Booleano da esquerda é true ou o da direita também?
    true || true
    // vai retornar true

### Operadores de comparação para números/matemática:
   
    // É maior?
    1 > 1;
    // Vai retornar false

    // É menor?
    1 < 1;
    // Vai retornar false
   
    // É maior OU igual?
    1 >= 1;
    // Vai retornar true

    // É menor OU igual?
    1 <= 1;
    // Vai retornar true

### Bloco condicionais:
   
    // Escrevendo olá SOMENTE quando 1 > 0:
    if(1 > 0)
    {
       Console.WriteLine("Olá");
    }
    // Caso 1 NÃO for maior que 0, e 2 > 1, escreva Boa tarde!
    else if (2 > 1)
    {
       Console.WriteLine("Boa tarde");
    }

    // Caso NENHUMA das condições anteriores forem verdadeiras, escreva xau!
    else
    {
       Console.WriteLine("Xau");
    }

### Comandos do editor Visual Studio Code
Selecionando o texto...

Segurar a tecla shift e utilizar as setas

Comando para comentar:
CTRL + K + C

Comando para desfazer:
CTRL + Z

Comando para refazer:
CTRL + Y

Comando para descomentar:
CTRL + U

### Depurando a aplicação
1. Clicar no ícone da baratinha e depois no botão de engrenagem: 

2. Selecionar o texto '.Net Core'.

3. Alterar a opção "console" para "integratedTerminal".

4. Adicionar quantos breakpoint quiser (clicar na esquerda do número da linha).

5. Clicar na baratinha e depois no botão Start(verdinho).

6. Selecionar o terminal (Sair na tab "Debug Console").

7. F10 vai para a próxima linha.

8. F5 para o próxima breakpoint.

9. Shift + F5 para "saltar" a aplicação

10. CTRL + Shift + F5 para reiniciar o debug.
 