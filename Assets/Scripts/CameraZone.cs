using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraZone : Zone
{
    public Transform cameraPosition;
    private new CameraController camera;

    protected override void Start()
    {
        base.Start();
        camera = FindObjectOfType<CameraController>();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            camera.MoveTo(cameraPosition.position);
        }
    }
}
