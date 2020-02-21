using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject MenuPausa;

    void Start()
    {
        MenuPausa.SetActive(false);
    }

    public void BtnPausa()
    {
        MenuPausa.SetActive(true);
    }

    public void ReiniciarPausa()
    {
        Application.LoadLevel("Juego");
    }

    public void Resume()
    {
        MenuPausa.SetActive(false);
    }
}
