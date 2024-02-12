using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.position += movement * speed * Time.deltaTime;

        float rotationHorizontal = Input.GetAxis("Mouse X");
        float rotationVertical = Input.GetAxis("Mouse Y");

       transform.Rotate(0, rotationHorizontal * rotationSpeed * Time.deltaTime, 0);
    }
}