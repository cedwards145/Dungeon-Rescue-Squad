using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : Zone
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.Kill();
        }
    }
}