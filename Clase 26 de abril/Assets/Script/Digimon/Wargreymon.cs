using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wargreymon : Metalgreymon
{
    // Start is called before the first frame update
    void Start()
    {
        Nombre = "Wargreymon";
    }

    public override void Saludo()
    {
        base.Saludo();
        AtaqueEspecial();
    }

    public override void AtaquePrincipal()
    {
        Debug.Log("Mi ataque se llama: Gran Tornado");
    }

    public override void AtaqueSecundario()
    {
        Debug.Log("Mi ataque Secundario se llama: Fuerza Gaia");
    }

    public virtual void AtaqueEspecial()
    {
        Debug.Log("Mi ataque Especial se llama: Escudo Valiente");
    }
}
