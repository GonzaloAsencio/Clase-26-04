using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_2 : Movimiento
{
    [SerializeField] protected int Direccion = 1;
    [SerializeField] protected float Amplitud = 2;
    [SerializeField] protected float Frecuencia = 2;
    protected Vector3 CurrentPosition;
    

    private void Start()
    {
        CurrentPosition = this.transform.position;
    }
    public override void MoverObjecto()
    {
        transform.position = transform.up * Mathf.Sin(Time.time * Frecuencia) * Amplitud;
        CurrentPosition += transform.right * Time.deltaTime * Frecuencia * Direccion;
    }
}