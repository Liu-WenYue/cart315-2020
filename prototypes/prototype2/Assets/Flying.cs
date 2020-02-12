using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float movementSpeed = 100f;
    public float resetSpeed = 100f;
    public float shiftSpeed = 150f;
    public float controlSpeed = 50f;

    public Animator camRotation;

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * movementSpeed;

        if (Input.GetKey(KeyCode.O))
        {
            camRotation.SetBool("Left", true);
        }

        if (Input.GetKey(KeyCode.P))
        {
            camRotation.SetBool("Right", true);
        }

        if (!Input.GetKey(KeyCode.O) && !Input.GetKey(KeyCode.P))
        {
            camRotation.SetBool("Fly", true);
            camRotation.SetBool("Right", false);
            camRotation.SetBool("Left", false);
        }
        else
        {
            camRotation.SetBool("Fly", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * controlSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * controlSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * controlSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * controlSpeed;
        }

    }
}
