using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed; //How fast the player will move

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * MovementSpeed; //horizontal force being applied to the player
        float v = Input.GetAxis("Vertical") * MovementSpeed; //vertical force being applied to the player

        this.GetComponent<Rigidbody>().AddForce(new Vector3(h,0,v)); //Applies the Horizontal and Vertical force to the player's Rigidbody
    }
}
