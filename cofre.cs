namespace ex_02_cofredig;

using static System.Console;
using System;

public class Cofre_Digital
{

//atributos
private string dono;
private string senha;
private bool estáAberto;
private int tentativasErradas;

//construtores
public Cofre_Digital(string dono, string senha)
{
    this.dono = dono;
    this.senha = senha;
    this.estáAberto = false;
    this.tentativasErradas = 0;
}

public void abrir(string senha)
{
    if (senha == this.senha)
    {
        estáAberto = true;
        tentativasErradas = 0;
        WriteLine("cofre aberto");
    }
    else
    {
        tentativasErradas++;
        WriteLine("senha incorreta: " + tentativasErradas);
    }
}

public void fechar()
{
    estáAberto = false;
}

public void AlterarSenha(string senhaAntiga, string senhaNova)
    {
        if (estáAberto == true)
    {
    if (senhaAntiga == this.senha)
    {
        this.senha = senhaNova;
        WriteLine("senha alterada com sucesso");
    }
    else
    {
        WriteLine("senha antiga incorreta, não foi possível alterar a senha");
    }
    }
    else
    {
        WriteLine("cofre fechado, não foi possível alterar a senha");
    }
    }

}