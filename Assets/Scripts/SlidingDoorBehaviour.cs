using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoorBehaviour : MonoBehaviour
{
    [Range(0, 1)]
    public float MovementSpeed;

    [Range(1,10)]
    public float TriggerDistance;

    public bool IsOpen;

    public Vector3 EndPos;
    public Vector3 StartPos;

    void Start()
    {
        StartPos = transform.position;
        IsOpen = false;
    }

    void Update()
    {
        if (IsOpen)
        {
            transform.position = Vector3.Lerp(transform.position, EndPos, Time.deltaTime * MovementSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, StartPos, Time.deltaTime * MovementSpeed);
        }
    }
    
    public void OpenDoor()
    {
        IsOpen = true;
    }

    public void CloseDoor()
    {
        IsOpen = false;
    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(EndPos, transform.localScale);
    }
#endif
}
