# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## 🐱‍👤 Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## 📄 Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## 🚗 Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## 🎲 Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## 🎯 Solução
Com o objetivo de criar um sistema que trabalha com smartphones, o código foi desenvolvido e complementado utilizando programação orientada a objetos (POO) em C#. Para permitir que marcas diferentes de aparelhos tenham seus próprios comportamentos, foi utilizada a abstração de uma classe base. Além disso, foram aplicados conceitos de herança de classes e polimorfismo para melhorar a eficiência do sistema.

O projeto contém três classes principais:

1. **`Smartphone`**: Esta é uma classe abstrata que define a estrutura básica de um smartphone. Ela contém quatro propriedades (Número, Modelo, IMEI, Memoria) e três métodos (Ligar, ReceberLigacao, InstalarAplicativo). O método InstalarAplicativo é abstrato e deve ser implementado nas classes que herdam dela. Esta classe não pode ser instanciada.

2. **`Nokia`**: Esta classe herda da classe Smartphone e implementa o método InstalarAplicativo. Quando este método é chamado, ele exibe uma mensagem indicando que o aplicativo está sendo instalado no Nokia.

3. **`Iphone`**: Esta classe também herda da classe Smartphone e implementa o método InstalarAplicativo. Quando este método é chamado, ele exibe uma mensagem indicando que o aplicativo está sendo instalado no Iphone.

### 👩‍💻 Tecnologias Utilizadas
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

![Git](https://img.shields.io/badge/git-%23F05033.svg?style=for-the-badge&logo=git&logoColor=white)

![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)

### ✔ Requisitos
- SDK .NET Core para compilar e executar a aplicação

### 🎁 Como Executar
- Abra o terminal do seu VS Code ou prompt de comando
- Navegue até o diretório onde está salvo o projeto
- Para usar as classes, você pode criar um novo objeto da classe Nokia ou Iphone e chamar o método InstalarAplicativo.
- Execute os comandos:
    - dotnet build
    - dotnet run