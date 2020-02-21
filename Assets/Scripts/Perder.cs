using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perder : MonoBehaviour
{
    public GameObject MenuPerder;
    public GameObject Nave;
    public GameObject ExplosionAnimacion;

    void Start()
    {
     
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Pared"))
        {
            Destroy(gameObject);
            Debug.Log("APARECIO EL GAMEOVER");
            MenuPerder.SetActive(true);
        }
    }
}
