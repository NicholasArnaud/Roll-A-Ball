using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>    
    ///Create a new public variable of type float that we will use to control how fast
    ///the player will move in the world
    /// - We make this variable public so that we can edit the value of it in the inspector at
    ///   runtime and while in the editor so we don't have to open the script every time just to 
    ///   change the value.
    /// </summary>
    public float MovementSpeed; //How fast the player will move
    
    /// <summary>
    /// Update is called every frame this script is enabled. 
    /// We will use this function to move our player object around the game space
    /// </summary>
    void Update()
    {
        //Create to variables that will hold value for our horizontal and vertical movement
        //Assign the value of the horizontal variable to the return value of the Unity function
        //Input.GetAxis("Horizontal") then multiply that value by the MovementSpeed variable
        //we create above
        //Do the same thing for the vertical variable but instead of doing
        //Input.GetAxis("Horizontal") replace "Horizontal" with "Vertical"
        float h = Input.GetAxis("Horizontal") * MovementSpeed; //horizontal force being applied to the player
        float v = Input.GetAxis("Vertical") * MovementSpeed; //vertical force being applied to the player

        //Now that we have the horizontal and vertical values set we will use them to create
        //a force then apply it to the rigidbody component on the player
        this.GetComponent<Rigidbody>().AddForce(new Vector3(h,0,v)); //Applies the Horizontal and Vertical force to the player's Rigidbody
    }
}
