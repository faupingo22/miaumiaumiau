using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class statsenemai : MonoBehaviour
{
    public float videl;
    public Image barrita;
    public float hptotall;

    public void Start()
    {
        hptotall = videl;
    }

    public void Recibidamage(float damaje)
    {
        videl -= damaje;
        ActualizaBarrita();
        if (videl <= 0)
        {
            Postmortem();
        }
    }
    public void ActualizaBarrita()
    {
        barrita.fillAmount = videl / hptotall;
    }
   private void Postmortem()
   {
      Destroy(gameObject);
   }
}
