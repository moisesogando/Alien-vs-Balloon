using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public AudioSource au;
    public Transform Lanzador;
    public GameObject DisparoPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            au.Play();
            Instantiate(DisparoPrefab, Lanzador.position, Lanzador.transform.rotation);
        }
    }

 }
