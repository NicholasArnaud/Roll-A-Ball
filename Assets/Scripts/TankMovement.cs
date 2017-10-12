using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [Range(1.0f, 10.0f)]
    public float RotateSpeed; //Speed at which the object will rotate on the Y Axis
    [Range(1.0f, 20.0f)]
    public float MovementSpeed; //Speed at which the object will move forward or backwards
    public Rigidbody RB; //Rigidbody component attached to the object we will use to 
                         //apply physics to our object

    /// <summary>
    /// DO NOT MODIFY
    /// The Start function is called when the object is first created in the game.
    /// </summary>
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

    /// <summary>
    /// Called only on Physics update. Unlike the Update function that is called every
    /// frame.
    /// </summary>
    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Horizontal"); //Gets the value 
                                                      //returned by the
                                                      //Horizontal axis.
                                                      //This will be used to
                                                      //drive our objects
                                                      //rotation
        float movement = Input.GetAxis("Vertical") * MovementSpeed; //Gets the value 
                                                                    //returned by the
                                                                    //Vertical axis.
                                                                    //This will be used to
                                                                    //drive the forward 
                                                                    //and backwards 
                                                                    //movement

        transform.Rotate(new Vector3(0, rotation, 0), RotateSpeed); //Rotates the object
                                                                    //on the Y axis
        
        RB.AddForce(transform.forward * movement); //Applies a force to the rigidbody on
                                                   //the object to drive the object
                                                   //forward
    }
}
