# Clean Arquitecture

# Desafio

Para entender melhor como a Arquitetura Limpa funciona, desafiamos você a construir uma solução para o problema a seguir:

Você recebeu o contato de uma ONG (Organização não Governamental) que trabalha com distribuição de alimentos para outras ONGs, de acordo com o que pedem. A ONG recebe as doações em pacotes, com diversos alimentos dentro, armazena e depois entrega essas doações em outros pacotes.

Por exemplo, a Organização não Governamental na qual você tem o contato pode receber um pacote com 200 kg de arroz, 100kg de feijão e 300 latas de óleo, e recebe um pedido de outra ONG pedindo a doação de 30kg de arroz, 10kg de feijão e 15 latas de óleo. Para isso, a entrega deve ser feita com outros pacotes, visto que será necessária uma separação diferente.

## Proposta

O objetivo é fazer uma arquitetura e uma aplicação que:

- Registre o recebimento dos pacotes, assim como também cadastre separadamente os produtos recebidos de acordo com o peso ou unidades;
- Registre os pedidos de doação, com as quantidades de produtos solicitadas;
- Valide se é possível atender aos pedidos;
- Emita uma listagem completa dos pedidos efetuados;
- Emita uma listagem do estado atual do estoque de alimentos;
- Efetue a entrega de um pedido, fazendo a baixa das quantidades no estoque e registrando a entrega.

## Orientações

- Comece pensando em resolver apenas uma das regras de negócio (caso de uso), e vá melhorando o desenho da arquitetura de acordo com os outros casos de uso. Não resolva todos os problemas de uma vez;
- Resolva o problema sempre pensando na simplicidade e no atendimento ao caso de uso. Não defina mais que o necessário;
- Pense na solução antes de implementá-la; use a arquitetura para guiar a implementação de código.


# Solução

## Linguagem Ubíqua

**ONG** Organização não governamental.  
**ONG Distribuidora** Tipo de ONG que recebe doações para fazer repasses para ONGs receptoras.   
**ONG Receptora** Tipo de ONG que solicita doações para ONGs distribuidoras.   
**Produto** Um item que possuí tipo e quantidade, podem compor doações e pedidos de doações.   
**Estoque** Lista de produtos armazendos em uma ONG.    
**Doação** Fornecer produtos a uma ONG Distribuidora.   
**Pedido** Solicitar uma lista de produtos a uma ONG Distribuidora.  


## Casos de Uso

#### Criar Pedido (ONG Receptora, ONG Distribuidora, Lista<Produtos>)
Uma ONG Receptora irá solicitar uma lista de produtos a uma ONG Distribuidora.  
O Pedido deverá ser criado contendo o status de "Pendente" e com a Data/Hora atual como Data de Solicitação.

#### Receber doação (Doação)
Lista de produtos recebidos pela ONG Distribuidora para incrementar o estoque. 

#### Listar Pedidos (ONG Distribuidora)
Mostra todos os pedidos, com todos os status, recebidos por uma ONG Distribuidora. 

#### Listar Estoque (ONG Distribuidora)
Mostra todos os Produtos, com suas respectivas quantidades e unidades de medida, disponíveis em uma ONG Distribuidora. 

#### Validar Pedido (Pedido)
Verifica se na ONG Distribuidora, informada no pedido, 
há todos os itens com suas respectivas quantidades disponíveis no estoque,  
caso não encontre algum item ou não tenha a quantidade suficiente,  
o Pedido deve ser Recusado, se todos os itens estiverem disponíveis, o Pedido deverá ser Processado. 

#### Recusar Pedido (Pedido)
Atualiza o status do Pedido para Recusado. 

#### Processar Pedido (Pedido)
Atualiza o status do pedido para Processado. 

#### Baixar Estoque (Pedido)
Subtrai do estoque atual da ONG Distribuidora, os itens do pedido Processado. 