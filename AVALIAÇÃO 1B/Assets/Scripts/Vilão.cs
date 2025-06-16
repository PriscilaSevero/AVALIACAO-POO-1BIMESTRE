using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vilão : MonoBehaviour
{

    public string inimigo; 
    public int energiaInimigo;
    public float velocidadeIimigo;
    public float puloInimigo;
    public int ataqueInimigo;
    
    public Vilão(string inimigo, int energiaInimigo, float velocidadeIimigo, float puloInimigo, int ataqueInimigo)
    {
        this.inimigo = inimigo;
        this.energiaInimigo = energiaInimigo;
        this.velocidadeIimigo = velocidadeIimigo;
        this.puloInimigo = puloInimigo;
        this.ataqueInimigo = ataqueInimigo;
    }

    public string setInimigo()
    {
        return this.inimigo;
    }

    public int setEnergiaInimigo()
    {
        return this.energiaInimigo;
    }

    public float setVelocidadeInimigo()
    {
        return this.velocidadeIimigo;
    }

    public float setPuloInimigo()
    {
        return this.puloInimigo;
    }

    public int setAtaqueInimigo()
    {
        return this.ataqueInimigo; 
    }

        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
