using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Zone : MonoBehaviour
{
    protected Collider zoneCollider;

    // Use this for initialization
    protected virtual void Start()
    {
        zoneCollider = GetComponent<Collider>();
        zoneCollider.isTrigger = true;
    }
    
    protected virtual void OnTriggerEnter(Collider other)
    { }

    protected virtual void OnTriggerExit(Collider other)
    { }
}
