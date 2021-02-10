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
- Instale o Visual Studio Code (https://code.visualstudio.com/download)
  - Para o VSCode funcionar, instale também o `.NET SDK 4.7.1`: https://www.microsoft.com/en-us/download/details.aspx?id=56119
  - Dicas de configuração: https://www.youtube.com/watch?v=Ny5g3YwPT5Y

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

## Criação do Jogador

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

## Aumentando o tamanho dos objetos (reduzindo a área da câmera)

- Saia do modo `Play` (garanta que o botão `Play` **não está azul**)
- Selecione a `MainCamera` na `Hierarchy`
- Vá no `Inspector` e procure pelo componente chamado `Camera`
- Dentro desse componente, há uma propriedade chamada `Size`, mude o valor de `5` para `1.2`
- Aperte `Play`
- Certifique-se de que o slider de `Scale`, na aba `Game`, está todo para esquerda

## Criando o Fundo

- Saia do modo `Play`
- Vá até a pasta `Assets/Pixel Adventure 1/Assets/Background` e escolha um dos fundos disponíveis
- Arraste e solte para a cena
- Com o **objeto do fundo selecionado**, vá no `Inspector` e procure pelo componente `Sprite Renderer`
- Vá na opção `Order in Layer` e mude de `0` para `-1`
- Mude a opção `Draw Mode` de `Simple` para `Tiled`, para que a imagem se ajuste conforme o tamanho
- Mude o `Size` `Width` para `4.5` e `Height` para `2.5`
- Clique com o botão direito em cima do componente `Transform` e selecione e opção `Reset`

## Ajustando o tamanho da janela do `Game`

- Na janela do `Game`, procure pela opção `Free Aspect`
- Clique nessa opção, vá no final da janelinha que abriu e clique em `+`
- Na Label, digite `Full HD`
- Coloque `1920` em `width` e `1080` em `Height`
- Clique em `Ok`

## Movimentação do Jogador

- Selecione o objeto do `Jogador`

- Vá no `Inspector` e clique em `Add Component`

- Digite `Jogador`, com `J` maiúsculo

- Pressione `Enter` duas vezes

- Isso deverá adicionar um novo componente de script ao seu objeto

- Para abrir, dê dois cliques na caixinha com o nome `Jogador`

- Isso deverá abrir o `Visual Studio Code` com o script do `Jogador` aberto

- No script que foi aberto, substitua o código atual pelo seguinte código:

- ```c#
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Jogador : MonoBehaviour
  {
      public float velocidade = 1f;
  
      // Start is called before the first frame update
      void Start()
      {
  
      }
  
      // Update is called once per frame
      void Update()
      {
          var h = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
          var v = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
  
          transform.Translate(
              h,
              v,
              0
          );
      }
  }
  
  ```

## Criação do cenário

- Vá até a pasta `Assets/Pixel Adventure 1/Assets/Items/Boxes/Box 1` e arraste o arquivo `Idle` para a cena. Na `Hierarchy`, mude o nome do novo objeto criado para `Caixa`.
- Vá até a pasta `Assets/Pixel Adventure 1/Assets/Traps/Blocks` e arraste o arquivo `Idle` para a cena. Na `Hierarchy`, mude o nome do novo objeto criado para `Pedra`.
- Selecione o objeto da `Caixa`, vá no `Inspector` e clique em `Add Component`. Digite `Box Collider 2D` e pressione `Enter`.
- Selecione o objeto do `Jogador`, vá no `Inspector` e clique em `Add Component`. Digite `Polygon Collider 2D` e pressione `Enter`.
- Ainda no `Inspector` do `Jogador`, adicione um novo componente chamado `Rigidbody2D`. Nesse componente adicionado, mude o valor da opção `Gravity Scale` de `1` para `0`. Expanda a área de `Constraints` e ative a opção `Freeze Rotation` `Z`.
- Selecione o objeto da `Caixa`, vá no `Inspector` e clique em `Add Component`. Digite `Polygon Collider 2D` e pressione `Enter`.

## Arrastando a caixa

- Abra o script do `Jogador`

- Logo após a chave `}` que fecha o método `Update`, mas antes da chave `}` que fecha a classe `Jogador`, crie um novo método, chamado `void OnCollisionEnter2D(Collision2D other) {}`.

- O arquivo`Jogador.cs` deverá ter o seguinte conteúdo:

- ```c#
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Jogador : MonoBehaviour
  {
      public float velocidade = 1f;
  
      GameObject caixaColidindo;
  
      // Start is called before the first frame update
      void Start()
      {
  
      }
  
      // Update is called once per frame
      void Update()
      {
          var h = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
          var v = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
  
          transform.Translate(
              h,
              v,
              0
          );
      }
  
      private void OnCollisionEnter2D(Collision2D other)
      {
          if (other.gameObject.CompareTag("Caixa"))
          {
              caixaColidindo = other.gameObject;
          }
      }
  
      private void OnCollisionExit2D(Collision2D other)
      {
          if (caixaColidindo == other.gameObject)
          {
              caixaColidindo = null;
          }
      }
  }
  
  ```

- Volte para a Unity e selecione o objeto da `Caixa`

- No `Inspector`, clique na opção `Tag: Untagged` e clique em `Add Tag`

- Expanda a opção `Tags` e clique no botão `+`

- Digite `Caixa`, da mesma forma que escrevemos no Script, com `C` maiúsculo e pressione `Enter`

- Selecione novamente o objeto da `Caixa` e clique novamente na opção `Tag: Untagged`

- Selecione a opção `Caixa` que acabamos de criar

- Volte para o Script do `Jogador` e substitua pelo seguinte conteúdo:

- ```c#
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Jogador : MonoBehaviour
  {
      public float velocidade = 1f;
  
      GameObject caixaColidindo;
  
      GameObject caixaArrastando;
  
      // Start is called before the first frame update
      void Start()
      {
  
      }
  
      // Update is called once per frame
      void Update()
      {
          var h = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
          var v = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
  
          transform.Translate(
              h,
              v,
              0
          );
  
          if (Input.GetKeyDown(KeyCode.Space))
          {
              if (caixaArrastando)
              {
                  caixaArrastando.transform.parent = null;
  
                  caixaArrastando = null;
              }
              else if (caixaColidindo)
              {
                  caixaArrastando = caixaColidindo;
  
                  caixaArrastando.transform.parent = transform;
              }
          }
      }
  
      private void OnCollisionEnter2D(Collision2D other)
      {
          if (other.gameObject.CompareTag("Caixa"))
          {
              caixaColidindo = other.gameObject;
          }
      }
  
      private void OnCollisionExit2D(Collision2D other)
      {
          if (caixaColidindo == other.gameObject)
          {
              caixaColidindo = null;
          }
      }
  }
  
  ```

