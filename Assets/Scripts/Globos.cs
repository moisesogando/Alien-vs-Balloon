using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Globos : MonoBehaviour
{
    public float Velocidad = 6;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.up * Velocidad + Vector3.right * Random.Range(-1, 1);
    }

    void Colision()
    {
        print("Globo colision");
    }
}
