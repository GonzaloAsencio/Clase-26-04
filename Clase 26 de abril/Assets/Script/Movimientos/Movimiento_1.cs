using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_1 : Movimiento
{
    public override void MoverObjecto()
    {
        rb2d.transform.Translate(Vector3.right * Velocidad * Time.deltaTime);
    }
}
