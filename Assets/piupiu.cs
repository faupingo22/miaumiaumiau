using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class piupiu : MonoBehaviour
{
    public GameObject bullet;
    public Transform disparo;
    public float forceDispar;
    public float timePium;
    private float timeLastBullet;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1") && canPium())
        {
            disparar();
        }
    }

    bool canPium()
    {
        return Time.time >= timeLastBullet + timePium;
    }

    public void disparar()
    {
        GameObject Bullet = Instantiate(bullet, disparo.position, disparo.rotation);
        Vector3 dispardirection = Camera.main.transform.forward;
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(dispardirection * forceDispar,ForceMode.Impulse);
        timeLastBullet = Time.time;
    }
}
