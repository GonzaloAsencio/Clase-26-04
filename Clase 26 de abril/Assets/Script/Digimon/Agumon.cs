using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agumon : Koromon
{
  
    void Start()
    {
        Nombre = "Agumon";
        
    }

    public override void Saludo()
    {
        base.Saludo();
    }

    public override void AtaquePrincipal()
    {
        Debug.Log("Mi ataque se llama: Llama Bebé/Flama Bebe");
    }
}
