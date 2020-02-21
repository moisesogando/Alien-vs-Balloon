using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text t;

    public int puntaje;

    public static Puntaje puntajeActual;

    void Start()
    {
        puntajeActual = this;
    }

    public void ActualizarPuntaje()
    {
        puntaje++;
        t.text = puntaje.ToString(); 
    }

    public void ActualizarPuntajeAzul()
    {
        puntaje += 10;
        t.text = puntaje.ToString(); 

    }
}
