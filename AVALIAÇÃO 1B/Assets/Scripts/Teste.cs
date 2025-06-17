using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    
    G
    public void CompararForcaCom(Vilao inimigo)
    {
        if (Demonio.getEnergia < inimigo.getAtaqueInimigo())
        {
            Debug.Log($"{Personagem.getPersonagem()} é mais fraco que {inimigo.getNomeInimigo()}.");
            
        }
        
        Debug.Log($"{this.demonio} é mais forte que {inimigo.getNomeInimigo()}.");
        
        
        else if (this.forca < outro.forca)
            return $"{outro.nome} é mais forte que {this.nome}.";
        else
            return $"{this.nome} e {outro.nome} têm a mesma força.";

    }

    // SCRIPT DO DEBUG.LOG
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
