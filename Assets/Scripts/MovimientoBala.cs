using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public float Velocidad = 15;
    public int agresion = 5;
    public Rigidbody rd;

    void Start()
    {
        rd.velocity = transform.right * Velocidad;
    }

    void onTriggerEnter(Collider col)
    {
        ExplotarGlobos explotarGlobos = col.GetComponent<ExplotarGlobos>();
        if (explotarGlobos != null)
        {
            explotarGlobos.Agredir(agresion);
        }
        
        DestroyObject(gameObject);
    }
    
    void Update()
    {
        transform.position += transform.up * Velocidad * Time.deltaTime;
    }
    
}
