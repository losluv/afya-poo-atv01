namespace ex_04_personagem_RPG;

public class Personagem_RPG
{

//constantes
private const int vida_max_guerreiro = 150;
private const int vida_max_mago = 80;
private const int nivel_max = 99;
private const int nivel_min = 1;

//atributos
private string nome;
private string classe;
private int nivel;
private int vida_atual;
private int vida_maxima;

//construtores
public Personagem_RPG(string nome, string classe)
{
    this.nome = nome;
    this.classe = classe;
    this.nivel = 1;

    if (classe == "guerreiro")
    {
        this.vida_maxima = vida_max_guerreiro;
        this.vida_atual = vida_max_guerreiro;
    }
    else if (classe == "mago")
    {
        this.vida_maxima = vida_max_mago;
        this.vida_atual = vida_max_mago;
    }
    else
    {
        Console.WriteLine("classe inválida");
    }

}

//metodos
public void ReceberDano(int dano)
    {
        if (dano > 0)
        {
            this.vida_atual -= dano;
            if (vida_atual <= 0)
            {
                vida_atual = 0;
                Console.WriteLine(nome + " YOU DIED"); //sim, é uma referência a dark souls
            }
        }
        else
        {
            Console.WriteLine(nome + "foi forte demais, o dano não surgiu efeito!!");
        }
    }

public void Curar(int cura)
{
    if (cura > 0)
    {
        this.vida_atual += cura;
        if (vida_atual > vida_maxima)
        {
            vida_atual = vida_maxima;
        }
    }
    else
    {
        Console.WriteLine(nome + "já está curado, pare de gastar poções valiosas!!");
    }

    if (vida_atual == 0)
    {
        Console.WriteLine(nome + "morreu, como que ele(a) bebeu uma poção de cura??");
    }
    else
    {
        Console.WriteLine(nome + "se curou, vida atual: " + vida_atual);    
    }
}

public void SubirNivel()
    {
        if (nivel < nivel_max)
        {
            nivel++;
            Console.WriteLine(nome + " subiu para o nível " + nivel);
        }
        else
        {
            Console.WriteLine(nome + " já atingiu o nível máximo");
        }
    }

public void ToString()
    {
        Console.WriteLine("nome: " + nome);
        Console.WriteLine("classe: " + classe);
        Console.WriteLine("nível: " + nivel);
        Console.WriteLine("vida atual: " + vida_atual);
        Console.WriteLine("vida máxima: " + vida_maxima);
    }
}
