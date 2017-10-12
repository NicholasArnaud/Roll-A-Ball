using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterController : MonoBehaviour
{
    GameObject[] teleporters;
    // Use this for initialization
    void Start()
    {
        List<string> keyLog = new List<string>();
        teleporters = GameObject.FindGameObjectsWithTag("Teleporter");
        foreach (var a in teleporters)
        {
            keyLog.Add(a.GetComponent<Teleporter>().Key);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        
    }


    public GameObject GetLink(GameObject teleporter)
    {
        foreach(var a in teleporters)
        {
            if (teleporter.GetComponent<Teleporter>().Key == a.GetComponent<Teleporter>().Key)
            {
                return a.gameObject;
            }
        }
        return null;
    }

}
