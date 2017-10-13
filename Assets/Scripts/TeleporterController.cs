using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterController : MonoBehaviour
{
    public List<Teleporter> teleporters;
    // Use this for initialization
    void Start()
    {
        foreach (var obj in GameObject.FindGameObjectsWithTag("Teleporter"))
            teleporters.Add(obj.GetComponent<Teleporter>());

        for (int i = 0; i < teleporters.Count; i++)
        {
            int numOfDiffKeys = 0;
            int numOfSameKeys = 0;
            for (int j = 0; j < teleporters.Count; j++)
            {
                if (teleporters[i].Key == teleporters[j].Key)
                {
                    numOfSameKeys++;
                    if (numOfSameKeys > 2)
                    {
                        Destroy(teleporters[j].gameObject);
                        teleporters.RemoveAt(j);
                        numOfSameKeys = 2;
                    }
                }
                else
                {
                    numOfDiffKeys++;
                    if(numOfDiffKeys ==teleporters.Count -1)
                    {
                        Destroy(teleporters[i].gameObject);
                        teleporters.RemoveAt(i);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    public void Update()
    {

    }


    public GameObject GetLink(GameObject teleporter)
    {
        foreach (var a in teleporters)
        {
            Debug.Log("active key" + teleporter.GetComponent<Teleporter>().Key + "otehr key" + a.GetComponent<Teleporter>().Key);
            if (teleporter.GetComponent<Teleporter>().Key == a.GetComponent<Teleporter>().Key)
            {
                Debug.Log(a.name + " " + teleporter.name);
                if (teleporter.gameObject != a.gameObject)
                {

                    return a.gameObject;
                }
            }
        }
        return null;
    }

}
