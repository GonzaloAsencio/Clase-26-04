using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koromon : Botamon
{

    private void Start()
    {
        Nombre = "Kormon";
    }


    public override void Saludo()
    {
        base.Saludo();

        AtaquePrincipal();
    }

    public virtual void AtaquePrincipal()
    {
        Debug.Log("Mi ataque se llama : Lanzar Burbujas");
    }
}
