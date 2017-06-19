using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    /// <summary>
    /// On Trigger Enter is a unity physics function that is called when an another
    /// physics object comes inside of a trigger collider attached to the same object
    /// this script is attached to
    /// </summary>
    /// <param name="other">Object that has come in collision</param>
    void OnTriggerEnter(Collider other)
    {
        //Check to make sure the object that has come inside the trigger value was the player
        if (other.tag == "Player")
        {
            //Invoke the UpdateScore function from the ScoreKeeper script attached to the player
            //that came in collision with the object
            other.GetComponent<ScoreKeeper>().UpdateScore();
            //Destroy this object
            Destroy(this.gameObject);
        }
    }
}
