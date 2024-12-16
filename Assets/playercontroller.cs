using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float velocity;
    public float sensibilidadmouse;
    private Rigidbody rb;
    private Transform camara;
    private float rotationX;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camara = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadmouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadmouse;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        camara.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

    }
    private void FixedUpdate()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.right * movX + transform.forward * movY;
        rb.MovePosition(rb.position + movimiento * velocity * Time.deltaTime);

    }
}
