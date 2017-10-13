using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Teleporter : MonoBehaviour
{
    public string Key;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            GameObject otherTele = GetComponentInParent<TeleporterController>().GetLink(this);
            otherTele.GetComponent<Collider>().isTrigger = false;
            other.transform.position = otherTele.transform.position + new Vector3(0, 1, 0);
            StartCoroutine(DisableTele(2, otherTele));
            
        }
    }

    IEnumerator DisableTele(float seconds, GameObject teleporter)
    {
        yield return new WaitForSeconds(seconds);
        teleporter.GetComponent<Collider>().isTrigger = true;
    }
}