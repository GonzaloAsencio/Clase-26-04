using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greymon:Agumon
{
    // Start is called before the first frame update
    void Start()
    {
        Nombre = "Greymon";
      
    }


    public override void Saludo()
    {
        base.Saludo();
        AtaqueSecundario();
    }

    public override void AtaquePrincipal()
    {
        Debug.Log("Mi ataque se llama: Mega Flama/Llama:");
    }

    public virtual void AtaqueSecundario()
    {
        Debug.Log("Mi ataque Secundario se llama: Gran Ataque de Cuerno");
    }

}
