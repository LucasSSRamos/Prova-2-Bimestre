Nome: Lucas Steferson Silva Ramos RA: 044444 Data: 06/12/2023


QUESTÕES TEÓRICAS

Questão teórica 1 (0,5 ponto)
Em sala estudamos e aprofundamos nos conceitos de classe anêmica e classe rica, cite uma situação onde cada uma pode ser utilizada e descreva por que ela faz sentido nesses cenários.
R: 

Modelo Anêmico:
    public class Cliente
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
Não significa que o modelo seja inutilizável, entretanto, não é bem definido e utilizável em situações mais rígidas.

Modelo Rico:
    public class Cliente
    {
        public int Id{ get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }     
        public Cliente(int id, string nome, string endereco)
        {
            if (id < 0)
                throw new InvalidOperationException();
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException();
            Id = id;
            Nome = nome:
            Endereco = endereco;
        }
    }
Como podemos ver trata-se de um modelo mais desenvolvido e bem mais explorado, somente pode atribuir valores para as propriedades via construtor e os valores estão sendo validados.

Questão teórica 2 (0,5 ponto)
Um conceito estudamos muito em sala e exemplificamos foi o princípio do SOLID de responsabilidade única, descreva como ele é importante e dê um exemplo prático (pode usar os códigos que fizemos em aula, prova ou exercícios para descrever seu raciocínio).
R: a importância do princípio solid de responsabilidade única é a de que uma classe deve apenas possuir uma responsabilidade e tal resposabilidade deve estar encapsulada dentro dela.

Questão teórica 3 (0,5 ponto)
Em sala de aula aprendemos técnicas de validação de dados e suas importâncias, descreva exemplos de validação de dados, por quê elas são importantes e devemos preocupar com elas.
Cite pelo menos 3 motivos.
R:
