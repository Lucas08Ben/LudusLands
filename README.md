### UNIVERSIDADE FEDERAL DO CEARÁ

### CAMPUS QUIXADÁ

### ...

### DISCIPLINA DE INTRODUÇÃO AO DESENVOLVIMENTO DE JOGOS

### LUCAS BENJAMIM CUNHA BANDEIRA

### DOCUMENTO DE GAME DESIGN PARA O JOGO PLANÍCIE LUDUS

### IGUATU - CE, BRASIL

```
06/08/2020 - Versão Alpha
```

## SUMÁRIO




## 1 INTRODUCAO

```
Planície Ludus é uma pequena província agrícola onde existem diversas vilas. Nessas
vilas moram pessoas simples, gentis, alegres e em completa harmonia. Estava tudo bem até que
um dia um homem que se auto nomeia como General Tuk apareceu com seus lacaios e dominou
essas terras ingênuas. Hoje completa um ano que o General e o seu bando controla o fluxo de
pessoas que necessitam transitar de uma vila para outra, exigindo um pedágio exacerbado e
completamente injusto, fazendo com que pessoas fiquem com fome e doentes, deixando a vila
completamente sem estruturas de prosperar.
O jovem Alex trabalha em uma oficina sendo forçado a trabalhar de graça para
os homens do Tuk. Ele realiza todo tipo de manutenção nas máquinas armadas usadas pelos
capangas do general. Após um ano de submissão, Alex, com ajuda do seu tio, finalmente
conseguiu juntar peças suficientes e construir uma máquina poderosa o suficiente para enfrentar
todas as máquinas do General um de cada vez, como estava em seus planos.
```
## 1.1 Visão Geral do Jogo

```
O objetivo principal de cada fase é destruir a máquina inimiga. Para realizar isso,
se faz necessário destruir a casa de força da máquina, qualquer outro módulo da máquina é
irrelevante para o seu funcionamento, porém pode ser uma estratégia destruir primeiro as armas
da máquina inimiga para após destruir a casa de força.
```
## 1.2 Gênero, semelhanças e diferenças.

```
Este é um jogo de plataforma 2D muito parecido com o jogo CATS: Crash Arena
Turbo Stars, com as seguintes semelhanças:
```
- Os dois são um jogo de plataforma 2d
- Os dois possuem duelos de máquinas
    e diferenças:
- A máquina do Alex poderá ser controlada pelo jogador.
- A máquina possuirá diversos blocos modulares.
- Haverão apenas armas de fogo.
- As armas não atirarão automaticamente tão pouco aleatoriamente. (O jogador deverá
    designar em qual módulo o ataque será priorizado)


- A máquina será destruída apenas quando o bloco "casa de força"for destruído.
- As máquinas terão colisão, porem elas ficaram fixadas no chão, impossibilitando uma
    máquina passar sobre a outra.

## 1.3 Público e Mercado Alvos.

```
A partir de 9 anos.
```
## 1.4 Fluxo de Jogo

```
O jogo consiste em 4 Vilas. A Vila Jenipapeiro é a vila do nosso Herói, Alex.
Alex enfrentará o primeiro inimigo no caminho para a vila Carnaúba. O Segundo inimigo será
enfrentado no caminha para Oiticica, dessa vez ele deve levar um pacote para a cidade, se o
pacote for destruído a missão será fracassada. O terceiro inimigo estará no caminho para Angicos,
nessa fase Alex além de enfrentar o inimigo terá que levar dois passageiros consigo, e caso o
modulo dos passageiros seja destruído, a missão será fracassada. Por fim, o General Tuk aparece
no Jenipapeiro com a máquina dele, e Alex precisa enfrentar a maior máquina que ele conhece.
Após derrotar o general o Jogo é finalizado.
Aproximadamente 25 minutos para conclusão do jogo.
```
## 1.5 Aparência e Experiência

```
Oferece ao jogador a oportunidade de trabalhar valores como o senso de justiça.
```

## 2 INTERFACE E INTERAÇÃO

```
Esta sessão fala um pouco de como funciona as entradas e saídas do Jogo.
```
## 2.1 Entradas.

```
O Jogo receberá como entrada o teclado e o mouse.
```
## 2.1.1 Teclado.

- Setas direcionais esquerda e direita: Definem a força e a respectiva direção para qual a
    máquina irá se movimentar. Por exemplo, se a tecla seta esquerda for pressionada 3x a
    máquina ira se movimentar com velocidade 3 para a esquerda, em seguida, se a tecla seta
    para direita for pressionada 3x a máquina irá parar, pois será contabilizado como força
    zero, se após for pressionado mais duas vezes a tecla seta para direita a máquina irá se
    movimentar na velocidade dois para a direita e assim sucessivamente.

## 2.1.2 Mouse

- Botão direito do mouse: Seleciona o módulo que a máquina irá priorizar em destruir; ou
    acionam algum botão de interface, por exemplo o botão de pausa ou seleção do mapa, etc.

## 2.2 Saídas

Nesta sessão será descrito o retorno fornecido ao jogador. A figura 1 apresenta o
fluxograma de telas e menus.

## 2.2.1 Telas

- Tela de menus
- Tela de combate
- Tela do Mapa


```
Figura 1 – Diagrama das telas e menus.
```
```
Fonte: Elaborado pelo autor
```
## 2.2.2 Menus

- Menu inicial: No menu inicial aparecerá apenas um botão para jogar e um botão para
    ver os créditos. Quando o botão para jogar é pressionado, o usuário é levado para a tela
    do mapa. Quando o botão dos créditos é pressionado, uma caixa de texto aparece para
    apresenta os créditos juntamente com um botão "fechar"para voltar ao menu inicial.
- Menu de pausa: No menu de pausa terá dois botões, um para voltar para a tela do mapa e
    outro para retomar à fase.
- Menu do mapa: Após o usuário selecionar uma fase no mapa, aparecerá um menu que
    perguntará se ele realmente quer iniciar aquela fase.


## 3 APRESENTAÇÃO

```
Nesta sessão será descrito como a mecânica do jogo será desenvolvida.
```
## 3.1 Mecânica básica de exploração

```
Inicialmente o jogador deverá selecionar qual inimigo deseja-se enfrentar. Lem-
brando que o inimigo final (O General Tuk) só aparecerá disponível quando os outros três
inimigos forem destruídos.
```
## 3.1.1 Habilidades Inertes

## 3.1.2 Interação com NPCs e Cutscenes.

```
Uma caixa de diálogo abrirá mostrando a conversa do personagem com o NPC, e
um botão depróximoserá utilizado para continuar a conversa até ela chegar ao fim.
```
## 3.2 Mecânica básica de combate.

```
O jogador deverá selecionar um modulo da máquina para focar seus ataques para
que as armas comecem a disparar. O combate acaba quando o módulo casa de força é destruído.
```
## 3.2.1 Ações de combate

```
Selecionar um módulo.
```
## 3.2.2 Atributos Principais.

```
Cada módulo da máquina possui sua própria resistência (Isso significa que existem
módulos que aguentam mais dano que outros)
```
## 3.2.2.1 Ataque das armas de fogo

```
Vão existir 4 tipos de armas, cada um com seu atributo especial.
```
- Arma padrão: Arma que atira apenas para frente, só realiza um disparo por segundo. Causa
    dano 1.
- Arma direcional: Parecida com arma padrão, só que ela pode direcionar os projeteis.


- Arma rápida: Parecida com a arma padrão porém lança 5 projeteis por segundo.
- Canhão: lança um projétil que causa dano 5.

## 3.2.2.2 Ataques sem armas de fogo

```
Caso não sobre nenhuma arma de fogo, a máquina lançará projeteis a cada segundo
que sairá de dentro do módulo da casa de força que causam dano 1. Se isto ocorrer a máquina só
poderá andar na velocidade 1.
```
## 3.2.2.3 Defesa

```
A defesa poderá ser feita utilizando módulos para proteger o módulo da casa de força
(Lembrando que cada módulo tem seu valor próprio de resistência).
```
## 3.2.3 Atributos Iniciais / Evolução

```
Para a primeira missão, a máquina terá alguns módulos de armadura, para proteger o
módulo da casa de força e terá duas armas padrão.
```
## 3.2.3.1 Protagonistas

```
O protagonista dessa história é o Alex. Ele que irá desbravar a aventura de salvar a
sua terra natal.
```
## 3.3 Mapa.

```
No mapa aparecerão Quatro vilas, A vila jenipapeiro é a vila onde o Alex está
situado, portanto podemos escolher dentre quais das outras três vilas iremos viajar para enfrentar
o nosso inimigo.
```
## 3.4 Salvamento / Ponto Seguro.

```
Cada fase concluída com sucesso o progresso será salvo. A máquina do Alex recebe
um upgrade a cada batalha.
```

## 4 DETALHAMENTO TÉCNICO

## 4.1 Hardware

```
Plataforma PC.
```
## 4.2 Software.

```
Unity 3D, Visual Studio Code
```
## 4.3 Engine

```
Unity 3D
```

## 5 ARTE

## 5.1 Resumo do Estilo

## 5.2 Principais Referências

```
referências artísticas reais.
```
## 5.3 Concept Art.

```
Exemplos de cada. Documento contendo todos estes a parte.
```
## 5.3.1 Personagens.

```
Personagens bons:
```
- Alex
- Tio do Alex
- Grilo (Capanga do Tuk 1 e primo do Alex e filho do tio dele)
    Personagens maus:
- Grilo (Capanga do Tuk 1 e primo do Alex e filho do tio dele)
- Tiú (Capanga do Tuk 2)
- Peba (Capanga do Tuk 3)
- General Tuk

## 5.3.2 Cenários

- Carnaúba (Estrada)
- Oiticica (Estrada)
- Angicos (Estrada)
- Jenipapeiro (Estrada)

## 5.4 H.U.D.

H.U.D mostrando a potência de -5 à 5 (números negativos para esquerda e positivos
para a direita) da máquina, para mostrar ao usuário qual velocidade ele está usando. A figura 2
representa uma ideia de como este H.U.D. ficaria. O ponteiro vermelho indicaria qual a potencia


usada, e as setas em verde indicaria para qual lado essa potência está sendo aplicada.

```
Figura 2 – Exemplo do Velocímetro que será usado no H.U.D..
```
```
Fonte: Elaborado pelo autor
```

## ANEXO A –Banco de Dados

## A.1 Lista Completa de Fases

- #LVL01: localizado na estrada para Oiticica. Enfrentará o Grilo, Primo do alex e ele se
    juntará a causa.
- #LVL02: localizado na estrada para Angicos. Enfrentará o Tiú, Capanga fiel ao general
    Tuk.
- #LVL03: localizado na estrada para Carnaúba. Enfrentará o Peba, Capanga fiel ao general
    Tuk.
- #LVL04: localizado na entrada para Jenipapeiro. Enfrentará o General Tuk com a sua
    maior máquina.
       #Oiticica:
       Lista das localidades e elementos chaves de cada uma, categorizadas por referências
como #lvl101, #lvl

## A.2 Lista Completa de Personagens

- #per01: Alex
- #per02: Tio do Alex
- #per03: Grilo
- #per03: Tiú
- #per03: Peba
- #per03: General Tuk

## A.3 Lista Completa de Inimigos

- #ini01: Grilo. Primo do Alex, que após a batalha junta-se a causa. Possui uma máquina
    com alguns módulos de armadura de bronze e duas armas padrão.
- #ini02: Tiú. Capanga fiel ao Tuk. Possui uma máquina com alguns módulos de armadura
    de bronze e ferro, além de duas armas direcionais.
- #ini03: Peba. Capanga fiel ao Tuk. Possui uma máquina com alguns módulos de armadura
    de ferro, além de uma arma rápida.
- #ini04: General Tuk. Possui uma máquina com alguns módulos de armadura de ferro,


## além de uma arma rápida e um canhão.

## A.4 Lista Completa de itens

- 1 INTRODUCAO
- 1.1 Visão Geral do Jogo
- 1.2 Gênero, semelhanças e diferenças.
- 1.3 Público e Mercado Alvos.
- 1.4 Fluxo de Jogo
- 1.5 Aparência e Experiência
- 2 INTERFACE E INTERAÇÃO
- 2.1 Entradas.
- 2.1.1 Teclado.
- 2.1.2 Mouse
- 2.2 Saídas
- 2.2.1 Telas
- 2.2.2 Menus
- 3 APRESENTAÇÃO
- 3.1 Mecânica básica de exploração
- 3.1.1 Habilidades Inertes
- 3.1.2 Interação com NPCs e Cutscenes.
- 3.2 Mecânica básica de combate.
- 3.2.1 Ações de combate
- 3.2.2 Atributos Principais.
- 3.2.2.1 Ataque das armas de fogo
- 3.2.2.2 Ataques sem armas de fogo
- 3.2.2.3 Defesa
- 3.2.3 Atributos Iniciais / Evolução
- 3.2.3.1 Protagonistas
- 3.3 Mapa.
- 3.4 Salvamento / Ponto Seguro.
- 4 DETALHAMENTO TÉCNICO
- 4.1 Hardware
- 4.2 Software.
- 4.3 Engine
- 5 ARTE
- 5.1 Resumo do Estilo
- 5.2 Principais Referências
- 5.3 Concept Art.
- 5.3.1 Personagens.
- 5.3.2 Cenários
- 5.4 H.U.D.
- ANEXOS
- ANEXO A –Banco de Dados
- A.1 Lista Completa de Fases
- A.2 Lista Completa de Personagens
- A.3 Lista Completa de Inimigos
- A.4 Lista Completa de itens
- ANEXO B –Roteiro de Níveis
- B.1 Guia e cronograma.
- ANEXO C –Level Design de Níveis
- C.1 Mapa do Nível
- C.2 Puzzles Encontrados
- C.3 Inimigos Encontrados
- C.4 Itens encontrados.
- C.5 Cutscenes
- ANEXO D –Arte
- D.1 Personagens.
- D.2 Cenários.
- D.3 Objetos
- D.4 HUD
- D.5 Texturas Usadas
- D.6 Efeitos Visuais
- ANEXO E –Som
- E.1 Efeitos Sonoros
- E.1.1 Ambiente.
- E.1.2 Combate
- E.1.3 Ações.
- E.1.4 Interface
- E.2 Músicas
- E.3 Vozes.
- • #itm01: MóduloCobre1x1: resistência A.4 Lista Completa de itens
- • #itm02: MóduloFerro1x1: resistência
- • #itm03: MóduloCobre2x2: resistência
- • #itm04: MóduloFerro2x2: resistência
- • #itm05: MóduloCasaDeForça: resistência 20, dano por projétil
- • #itm06: ArmaPadrão: resistência 10, dano por projétil
- • #itm07: ArmaDirecional: resistência 10, dano por projétil
- • #itm08: ArmaRápida: resistência 10, dano por projétil
- • #itm09: Canhão: resistência 15, dano por projétil


## ANEXO B –Roteiro de Níveis

## B.1 Guia e cronograma.

O nível 1 é a estrada para Oiticica, onde Alex encontra o seu primo, apelidado como
grilo. Antes da batalha uma conversa acontece, e depois da batalha o Grilo percebe que é possível
se livrar do General Tuk, afinal estava trabalhndo para ele apenaspara sobreviver. Uma nova
conversa acontece entre Alex e Grilo e então Grilo se propõe a ajudar a sabotar a máquina pessoal
do General Tuk.
No nível 2 é a estrada para Angicos, o objetivo de Alex é destruir o Tiú, o segundo
capanga de Tuk, mas também levar com ele, explosivos que serão usados para sabotar a máquina
do General Tuk.
no nível 3 é a estrada para Carnaúba, Alex precisa levar dois passageiros consigo,
pois são seus amigos próximos e estão muito doentes e não tem condições de pagar as taxas
exigidas. Então além de levar estes passageiros ele precisa derrotar o Peba, o terceiro capanga de
Tuk.
O nível 4, Alex recebe a notícia de que o General Tuk se aproxima de Jenipapeiro a
sua procura, então Alex sai da vila e o aguarda na entrada se preparando para enfrentá-lo mesmo
sabendo que não será uma batalha fácil.


## ANEXO C –Level Design de Níveis

## C.1 Mapa do Nível

Categorizando cada sala com #lvlxx.yy, Ex: #lvl01.01 (nível 1, sala 1), #lvl03.
(nível 3, sala 4)

## C.2 Puzzles Encontrados

```
Definindo as salas onde estes estarão.
```
## C.3 Inimigos Encontrados

```
Definindo as salas onde estes estarão.
```
## C.4 Itens encontrados.

```
Definindo o modo como este será encontrado, e a sala onde estará
```
## C.5 Cutscenes

Fazendo ligações diretas ao documento de roteiro para apontar a sala onde estas
ocorrerão.


## ANEXO D –Arte

## D.1 Personagens.

```
Concept Art e Sprints
```
## D.2 Cenários.

```
Concept Art e Sprints
```
## D.3 Objetos

```
Concept Art e Sprints
```
## D.4 HUD

## D.5 Texturas Usadas

## D.6 Efeitos Visuais


## ANEXO E –Som

## E.1 Efeitos Sonoros

## E.1.1 Ambiente.

## E.1.2 Combate

## E.1.3 Ações.

## E.1.4 Interface

## E.2 Músicas

## E.3 Vozes.


