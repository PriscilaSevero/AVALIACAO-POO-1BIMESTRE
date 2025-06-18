using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem guerreiro = new Personagem();
    Demonio demonio = new Demonio();
    
        void Start()
        {
            //atributos
            
            guerreiro.setNome("Guerreiro");
            guerreiro.setAtaque(15);
            guerreiro.setPulo(7f);
            guerreiro.setEnergia(12);
            guerreiro.setVelocidade(10f);

            demonio.setNome("Demonio");
            demonio.setAtaque(20);
            demonio.setPulo(10f);
            demonio.setEnergia(30);
            demonio.setVelocidade(20f);
            
            //atacou
            demonio.UsouChamasDoInferno(guerreiro);
            demonio.UsouChamasDoInferno(guerreiro);

            // energia depois do ataque
            if (guerreiro.Energia() <= 0)
            {
                Debug.Log("O " + guerreiro.Nome() + " está sem energia");
            }
            else
            {
                Debug.Log("O " + guerreiro.Nome() + " ainda tem " + guerreiro.Energia() + " de energia");
            }
        }

}
