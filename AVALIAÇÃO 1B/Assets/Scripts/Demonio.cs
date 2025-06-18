using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demonio : Personagem
{
    public string chamasDoInferno;
    public string arma;

    public void setChamasDoInferno(string chamasDoInferno)
    {
        this.chamasDoInferno = chamasDoInferno;
    }

    public string ChamasDoInferno()
    {
        return this.chamasDoInferno;
    }

    public void setArma(string arma)
    {
        this.arma = arma;
    }

    public string Arma()
    {
        return this.arma;
    }

    public void UsouChamasDoInferno(Personagem demonio)
    {
        demonio.setEnergia(demonio.energia =- 100);
        Debug.Log(demonio.Nome() + " Ainda possui " + demonio.Energia() + "de vida");
    }

}
