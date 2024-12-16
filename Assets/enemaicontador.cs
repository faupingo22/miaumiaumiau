using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemaicontador : MonoBehaviour
{
    private int enemaiAlive;
    public GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        enemaiAlive = GameObject.FindGameObjectsWithTag("enemai").Length;
    }

    private void Update()
    {
        enemaiAlive = GameObject.FindGameObjectsWithTag("enemai").Length;
        if ( enemaiAlive == 0 )
        {
            gameManager.CambiarEscena(2);
        }
    }
}
