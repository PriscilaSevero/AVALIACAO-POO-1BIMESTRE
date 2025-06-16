using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demonio : MonoBehaviour
{ 
    
        
    public string CompararForcaCom(Personagem outro)
    {
        if (Personagem.setAtaque > Vilão.ataqueInimigo)
        {
            return $"{this.demonio} é mais forte que {Vilão.inimigo}.";
            
        }
        else if (this.forca < outro.forca)
            return $"{outro.nome} é mais forte que {this.nome}.";
        else
            return $"{this.nome} e {outro.nome} têm a mesma força.";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
