using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statspayer : MonoBehaviour
{
    public float videla;
    public float tiempoPrepucioActivado;
    private float timLastDamaje;

    private GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Update()
    {
        if (Time.time < timLastDamaje + tiempoPrepucioActivado)
        {
            return;
        }
    }
    public void Recibirwaska(float damaje)
    {
        videla -= damaje;
        if (videla <= 0)
        {
            PostMortem();
        }

        timLastDamaje = Time.time;
    }
    private void PostMortem()
    {
        gameManager.desblokcucsor();
        gameManager.CambiarEscena(0);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemai"))
        {
            float danoenemai = 1f;
            Recibirwaska(danoenemai);
        }
    }
}
