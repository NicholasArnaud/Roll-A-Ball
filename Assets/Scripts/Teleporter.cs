using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    TeleporterController telecon;
    public string Key;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject otherTele = telecon.GetLink(gameObject);
            other.transform.position = otherTele.transform.position;
        }
    }
}
