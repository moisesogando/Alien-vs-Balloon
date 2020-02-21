using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarRV : MonoBehaviour
{
    public float InstanceRate = 5;
    public GameObject GlobosPrefabRojo;
    public GameObject GlobosPrefabVerde;


    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(GlobosPrefabRojo, transform.position, Quaternion.identity);
            
            Instantiate(GlobosPrefabVerde, transform.position, Quaternion.identity);
           
            yield return new WaitForSeconds(InstanceRate);
        }
    }
}
