using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoorController : MonoBehaviour
{
    public  List<SlidingDoorBehaviour> Doors;

    public GameObject Player;
	// Use this for initialization
	void Start ()
    {
        foreach (var door in gameObject.GetComponentsInChildren<SlidingDoorBehaviour>())
        {
            Doors.Add(door);
        }
        Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
    void Update()
    {
        foreach (var door in Doors)
        {
            float distanceToDoor = (Player.transform.position -
                                    door.transform.position).magnitude;
            if (distanceToDoor < door.TriggerDistance)
                door.OpenDoor();
            else
                door.CloseDoor();
        }
    }
}
