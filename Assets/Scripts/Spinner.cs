using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Tooltip("Speed at which the object rotates on X Axis")]
    [Range(-20, 20)]
    public float XRotationSpeed;
    [Tooltip("Speed at which the object rotates on Y Axis")]
    [Range(-20, 20)]
    public float YRotationSpeed;
    [Tooltip("Speed at which the object rotates on Z Axis")]
    [Range(-20, 20)]
    public float ZRotationSpeed;
    
	// Update is called once per frame
	void Update ()
    {
        //Rotates the object on each axis each frames based on the values of rotation
        //speeds for each axis set in the inspector
        transform.Rotate(new Vector3(XRotationSpeed, YRotationSpeed, ZRotationSpeed));
    }
}
