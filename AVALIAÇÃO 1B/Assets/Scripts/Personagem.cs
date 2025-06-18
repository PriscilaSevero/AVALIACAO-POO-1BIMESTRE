using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int energia;
    public float velocidade;
    public float pulo;
    public int ataque;

    
    public string Nome()
    {
        return this.nome;
    }

    public void setNome(string guerreiro)
    {
        this.nome = nome;
    }
    
    public int Energia()
    {
        return this.energia;
    }
    
    public void setEnergia(int energia)
    {
    this.energia = energia;
    }
    
    public float Velocidade()
    {
        return this.velocidade;
    }

    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Pulo()
    {
        return this.pulo;
    }

    public void setPulo(float pulo)
    {
        this.pulo = pulo;
    }

    public int Ataque()
    {
        return this.ataque;
    }

    public void setAtaque(int ataque)
    {
        this.ataque = ataque;
    }
    

   
    
    public void Morte (Personagem demonio)
    {
        if (this.energia <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}

    
