namespace atv_poo_afya_1;

using System;
using static System.Console;

git status
public class Lampada
{

//constantes
public const int MinBrilho = 0;
public const int MaxBrilho = 100;

//atributos
private string marca;
private readonly string tecnologia;
private bool ligada;
private int brilho;

//propriedades
public string Tecnologia => tecnologia;

//construtores

public Lampada(string marca, string tecnologia)
{
    this.marca = marca;
    this.tecnologia = tecnologia;
    this.ligada = false;
    this.brilho = 100;
}

//metodos

public void Alternar()
{
    if (ligada == true)
    {
        ligada = false;
    }
    else if (ligada == false)
    {
        ligada = true;
    }
}


public void AjustarBrilho(int nivel)
{
    if (nivel >= 0 && nivel <= 100)
    {
        this.brilho = nivel;
    }
}
}
