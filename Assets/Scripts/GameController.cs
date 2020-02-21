using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private int score;
    public Text txtscore;


    void Start()
    {
        score = 0;
        scoreUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void scoreUpdate()
    {
        txtscore.text = "" + score;
    }

    public void addScore(int valor)
    {
        score += valor;
        scoreUpdate();
    }
}
