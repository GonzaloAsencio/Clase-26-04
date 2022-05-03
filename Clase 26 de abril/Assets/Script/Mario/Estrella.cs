using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella :PowerUp
{
    public override void Consumible()
    {
        player.Cambio_de_Estado(Mario.MarioState.estrella);
    }
}
