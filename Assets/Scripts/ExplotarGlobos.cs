using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotarGlobos : MonoBehaviour
{
    AudioSource au;
    public int vida;

    public GameObject Globos;

    void Start()
    {
        au = Camera.main.GetComponent<AudioSource>();
    }

    public void Agredir(int agresion)
    {
        vida -= agresion;
        

        if ((vida <= 0)  && tag == "GloboAzul")
        {
            
            Explotando();

            Puntaje.puntajeActual.ActualizarPuntajeAzul();
        }
        
    }
   

    void OnTriggerEnter(Collider col)
    {
        
        Instantiate(Globos, transform.position, Quaternion.identity);
        if (col.CompareTag("Bala"))
        {
            au.Play();
            Puntaje.puntajeActual.ActualizarPuntaje();
            Destroy(gameObject);

            if ((GameHandler.health + .10f) > 1f)
            {
                GameHandler.health = 1f;
            }
            else
            {
                GameHandler.health += .10f;
            }
        }

    }

    void Explotando() {

        void OnTriggerEnter(Collider col)
        {
            Instantiate(Globos, transform.position, Quaternion.identity);
            if (col.CompareTag("Bala"))
            {
                Destroy(gameObject);
            }

        }
    }

}

 
