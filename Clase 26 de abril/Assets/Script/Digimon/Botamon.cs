using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Botamon : MonoBehaviour
{

    protected string Nombre;

    public virtual void Saludo()
    {
        Debug.Log("Hola mi nombre es:" + " " + Nombre);
    }

}
