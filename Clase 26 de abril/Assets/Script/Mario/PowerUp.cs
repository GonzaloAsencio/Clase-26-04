using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{

    protected string nombre;
    public Mario player;

    private void Start()
    {
        if(player != null)
        {
            player = GetComponent<Mario>();
        }else
        {
            player = FindObjectOfType<Mario>();
        }
    }

    public abstract void Consumible();

}
