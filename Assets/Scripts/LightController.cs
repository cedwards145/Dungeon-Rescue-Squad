using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightController : MonoBehaviour
{
    public Switch controllingSwitch;
    private Light controlledLight;

    // Use this for initialization
    void Start()
    {
        controlledLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        controlledLight.enabled = controllingSwitch.IsOn();
    }
}