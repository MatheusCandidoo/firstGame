# Meu primeiro jogo
Primeiro jogo que eu criei utilizando a Unity para a disciplina de Desenvolvimento de Jogos.

O jogo é um game de plataforma bem simples, o personagem principal tem o objetivo de encontrar uma chave que irá destravar uma porta no final do mapa. Ele precisa sobreviver a um inimigo e alguns obstáculos.

### O que eu aprendi?
* Com este projeto, eu consegui utilizar o `SceneManager` para gerenciar as cenas, que neste projeto são somente duas, menu e jogo.
* Utilizei RayCasting para entender sobre as colisões direcionadas aos pés do personagem, para matar os inimigo, se prender a plataforma e ao cenário, onde pertinente.
* Fora utilizar o `RigidiBody.velocity` para a movimentação do personagem, utilizei `transform.position` para movimentar a plataforma e o inimigo, apesar de ter esquecido de utilizar `Time.deltaTime` para equalizar a taxa de atualização.
* Para algumas estilizações, utilizei `transform.rotate()` para conseguir rotacionar no eixo x o Personagem Principal quando mudar a direção e também para dar o efeito de rotação na chave (objetivo do jogo).
* Utilização de Canvas para a __GUI__ do jogo.

### O que eu acho que podia ter feito melhor?
* Ter utizado o `Time.deltaTime` para equalizar a taxa de atualização do `transform.position`.
* Adicionado efeitos sonoros para melhorar a ambientação.
* Feito mais eventos automatizados, como spawns de npcs controlados por um gerenciador.

### Como eu faço para testar?
Basta baixar o arquivo build.zip na raiz do repositório na branch __*Main*__ descompactado e executar o arquivo **Projeto01.exe**.

#### Espero que gostem da versão inicial, caso tenham dúvidas ou sugestões, fiquem a vontade para enviar comentários!!!
