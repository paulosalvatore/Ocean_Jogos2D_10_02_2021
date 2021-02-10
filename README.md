# Vídeos para auxiliar

- Instalar e configurar a Unity e o Visual Studio Code
  - https://www.youtube.com/watch?v=Ny5g3YwPT5Y
- Primeiros passos na Unity:
  - https://www.youtube.com/watch?v=_q_bT1f36RQ
- Criação de um projeto (no caso, Jogo do Dino):
  - https://www.youtube.com/watch?v=t4AJQ6LwSVo
- Criação de um Space Shooter, do começo ao fim, em 3 horas:
  - https://www.youtube.com/watch?v=uHvqkFZK5Oo

## Instalação da Unity

- Instale o UnityHub

## Para instalar a Unity:
- No UnityHub, clique na aba `Installs`
- Clique na opção `Add`
- Selecione a última versão LTS da Unity 2019
- Desmarque todos os módulos que estão marcados
- Clique em `Done`

## Com a Unity Instalada, no UnityHub
- Clique na esquerda em `Projects`
- Clique em cima na direita em `Add`, na setinha
- Seleciona a versão da Unity
- Seleciona o template 2D
- Digita o nome do projeto, no caso, `Ocean_Jogos2D_10_02_2021`
- Coloca em uma pasta que vc queira ou deixe a pasta padrão
- Clique em `Create`
- Aguarde o projeto terminar de criar

## Importar o pacote

- Baixe o pacote (https://drive.google.com/file/d/1pykj22ek5FEguWfS4KuL5bzbaKQk5n-H/view)
- Com o projeto na Unity aberto, abra o arquivo baixado (`PixelAdventure1.unitypackage`)
- Uma janela de `Import Unity Package` aparecerá na Unity
- Clique no botão `Import`
- Aguarde
- Depois que importar, se quiser visualizar o conteúdo do pacote, navegue até a pasta`Pixel Adventure 1`, dentro tem uma pasta chamada `Scenes` com um arquivo chamado `Demo.unity`

## Construção do Projeto

- Abra o arquivo `SampleScene.unity` na pasta `Assets/Scenes`
- Abra a pasta `Pixel Adventure 1/Assets/Main Characters/Ninja Frog`
- Clique na setinha para expandir o arquivo `Idle (32x32)`
- Dê um clique no arquivo `Idle (32x32)_0`, segure o `Shift` e clique no arquivo `Idle (32x32)_10` para selecionar todos os arquivos
- Arraste e solte os arquivos selecionados para a `Scene`
- Uma janela para salvar a animação deve abrir
- Digite `Idle` e pressione `Enter`
- Na `Hierarchy`, selecione o novo objeto `Idle (32x32)_0`
- Vá no `Inspector` e mude o nome para `Jogador`, na caixinha que fica na parte superior com o nome do objeto
- Clique com o botão direito no `Transform` e selecione `Reset`
- Aperte `Shift + F` para visualizar onde o jogador está
- Aperte `Play`

## Aumentando o tamanho da câmera

- Saia do modo `Play`
- Selecione a `MainCamera` na `Hierarchy`
- Vá no `Inspector` e procure pelo componente chamado `Camera`
- Dentro desse componente, há uma propriedade chamada `Size`, mude o valor de `5` para `1.2`
- Aperte `Play`