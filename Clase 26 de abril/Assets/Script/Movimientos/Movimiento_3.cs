using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_3 : Movimiento_2
{
    public override void MoverObjecto()
    {
        transform.position = CurrentPosition + transform.up * Mathf.Cos(Time.time * Frecuencia) * Amplitud;
        CurrentPosition += transform.right * Time.deltaTime * Frecuencia * Direccion;
    }
}
