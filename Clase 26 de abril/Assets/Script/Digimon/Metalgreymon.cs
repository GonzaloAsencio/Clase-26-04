using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metalgreymon :Greymon
{
    // Start is called before the first frame update
    void Start()
    {
        Nombre = "Metalgreymon";
        
    }

    public override void Saludo()
    {
        base.Saludo();
       
    }

    public override void AtaquePrincipal()
    {
        Debug.Log("Mi ataque se llama: Giga Explosión/Giga Destructora");
    }

    public override void AtaqueSecundario()
    {
        Debug.Log("Mi ataque Secundario se llama: Brazo Tridente");
    }

}
