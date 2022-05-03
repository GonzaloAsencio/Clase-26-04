using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : PowerUp
{
    public override void Consumible()
    {
        player.Incremento_de_Vida();
    }
}
