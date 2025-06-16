using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string demonio;
    public int energia;
    public float velocidade;
    public float pulo;
    public int ataque;
    
    public Personagem(string demonio, int energia, float velocidade, float pulo, int ataque)
    {
        this.demonio = demonio;
        this.energia = energia;
        this.velocidade = velocidade;
        this.pulo = pulo;
        this.ataque = ataque;
    }

    public string setPersonagem()
    {
        return this.demonio;
    }

    public int setEnergia()
    {
        return this.energia;
    }

    public float setVelocidade()
    {
        return this.velocidade;
    }

    public float setPulo()
    {
        return this.pulo;
    }

    public int setAtaque()
    {
        return this.ataque; 
    }
    
    
  
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
