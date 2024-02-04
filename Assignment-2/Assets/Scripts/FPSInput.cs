using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
private CharacterController _charController;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float deltaZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = 0f;
        movement = transform.TransformDirection(movement);
        movement *= Time.deltaTime;
        _charController.Move(movement);
    transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}
