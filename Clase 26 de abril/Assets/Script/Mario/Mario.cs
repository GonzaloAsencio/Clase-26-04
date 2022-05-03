using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    [SerializeField] Sprite mariorojo;
    [SerializeField] private int vida = 0;
    [SerializeField] private bool inmune = false;
    private SpriteRenderer sr; 

    public enum MarioState {normal,fuego,estrella}
    public MarioState  mario_state = MarioState.normal;



    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        switch (vida)
        {
            case 0:
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0);
                break;
            case 1:
                this.transform.localScale = new Vector3(1, 1, 0);
                break;
            case 2:
                this.transform.localScale = new Vector3(1.3f, 1.3f, 0);
                break;
        }
       
        
        if(inmune)
        sr.color = Random.ColorHSV();
    }

   public void Cambio_de_Estado(MarioState mario_state)
    {
        switch (mario_state)
        {
            case MarioState.fuego:
                sr.sprite = mariorojo;
                Debug.Log("Tambien Tiro Fuego");
                break;

            case MarioState.estrella:
                inmune = true;
                Debug.Log("Soy inmunne a todo");
                break;
              
        }
    }

    public void Incremento_de_Vida()
    {
        if (vida <= 2) 
            vida++;   
    }

}
