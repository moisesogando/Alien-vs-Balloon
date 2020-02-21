using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            GameRestart();
        }
    }

    public void GameRestart()
    {
        SceneManager.LoadScene("Menu");
    }
}
