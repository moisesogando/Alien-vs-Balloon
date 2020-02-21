using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarAN : MonoBehaviour
{
    public float InstanceRate = 5;
    public GameObject GlobosPrefabAzul;
    public GameObject GlobosPrefabNaranja;


    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(GlobosPrefabAzul, transform.position, Quaternion.identity);

            Instantiate(GlobosPrefabNaranja, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(InstanceRate);
        }
    }
}
