using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string personagem;
    public int energia;
    public float velocidade;
    public float pulo;
    public int ataque;
    
    public Personagem(string personagem, int energia, float velocidade, float pulo, int ataque)
    {
        this.personagem = personagem;
        this.energia = energia;
        this.velocidade = velocidade;
        this.pulo = pulo;
        this.ataque = ataque;
    }

    public string setPersonagem()
    {
        return this.personagem;
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
