using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    [Range(1.0f, 10.0f)]
    public float RotateSpeed;
    [Range(1.0f, 10.0f)]
    public float MovementSpeed;
    public Rigidbody RB;

    void Start()
    {
        //If failed to assign values in the inspector this will assign some values to them
        if (RotateSpeed == 0)
            RotateSpeed = 1.0f;
        if (MovementSpeed == 0)
            MovementSpeed = 1.0f;
        if (RB == null)
            RB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Horizontal") * RotateSpeed;
        float movement = Input.GetAxis("Vertical") * MovementSpeed;

        Debug.Log(new Vector3(0, rotation, 0));
        transform.Rotate(new Vector3(0, rotation, 0));
        RB.AddForce(transform.forward * movement);
    }
}
