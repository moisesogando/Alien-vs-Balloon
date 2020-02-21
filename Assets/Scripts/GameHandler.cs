using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    public GameObject Nave;
    public GameObject MenuPerder;
    public static float health = 1f;

    private void Start()
    {
      
        FunctionPeriodic.Create(() => {
            if (health > 0) {
                health -= .001f;
                healthBar.SetSize(health);
                MenuPerder.SetActive(false);

                if (health  < .3f) {
                    if ((health * 100f) % 3 == 0)
                    {
                        healthBar.SetColor(Color.green);
                    }
                    else {
                        healthBar.SetColor(Color.red);
                    }
                    
                }
                if (health <= 0)
                {
                    Destroy(gameObject);
                    MenuPerder.SetActive(true);
                }
            }
        }, .03f);       
    }
}
