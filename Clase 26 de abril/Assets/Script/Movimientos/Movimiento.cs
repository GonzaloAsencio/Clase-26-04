using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movimiento : MonoBehaviour
{
    [SerializeField] protected float Velocidad;
    protected Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoverObjecto();
    }
    public abstract  void MoverObjecto();
}
