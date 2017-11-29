using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : Zone
{
    public int numberOfPlayersRequired;
    private List<PlayerController> players;

    protected override void Start()
    {
        base.Start();
        players = new List<PlayerController>();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            players.Add(player);

            if (players.Count == numberOfPlayersRequired)
            {
                Win();
            }
        }
    }

    protected override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);

        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            players.Remove(player);
        }
    }

    private void Win()
    {
        Debug.Log("Level complete");
    }
}