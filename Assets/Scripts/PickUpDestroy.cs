using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDestroy: MonoBehaviour
{
    public float DestroyDelay;
    bool BeingDestroyed = false;

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //Check to make sure the object that has come inside the trigger value was the player
        if (other.tag == "Player")
        {
            Destroy(this.GetComponent<CapsuleCollider>());
            BeingDestroyed = true;
        }
    }
}
