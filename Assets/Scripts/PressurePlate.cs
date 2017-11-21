using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PressurePlate : Switch
{
    private List<GameObject> collidingObjects;
    private Collider plateCollider;

    // Use this for initialization
    void Start()
    {
        collidingObjects = new List<GameObject>();
        plateCollider = GetComponent<Collider>();
        plateCollider.isTrigger = true;
    }

    public override bool IsOn()
    {
        return collidingObjects.Count > 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        collidingObjects.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        collidingObjects.Remove(other.gameObject);
    }
}