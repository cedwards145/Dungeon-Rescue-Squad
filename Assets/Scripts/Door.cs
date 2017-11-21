using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Switch controllingSwitch;
    public Transform openPosition;
    public Transform closePosition;
    public Transform doorModel;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (controllingSwitch.IsOn())
        {
            doorModel.position = openPosition.position;
        }
        else
        {
            doorModel.position = closePosition.position;
        }
    }
}