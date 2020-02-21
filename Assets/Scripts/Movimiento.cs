using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Movimiento : MonoBehaviour
{
    Rigidbody rb;
    public float Velocidad = 8f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        
    }

    void Update()
    {
        Vector3 DireccionZ = Input.GetAxis("Vertical") * Vector3.up;
        Vector3 VectorVelocidad = DireccionZ * Velocidad;

        rb.velocity = VectorVelocidad;
    }
}
