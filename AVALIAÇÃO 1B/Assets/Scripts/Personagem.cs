using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personagem : MonoBehaviour
{
    public string demonio;
    public int energia;
    public float velocidade;
    public float pulo;
    public int ataque;

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

   
    
    public void Morte (Personagem demonio)
    {
        if (this.energia <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}

    
