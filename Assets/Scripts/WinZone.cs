using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    public int numberOfPlayersRequired;
    private List<PlayerController> players;
    private Collider zoneCollider;

    // Use this for initialization
    void Start()
    {
        zoneCollider = GetComponent<Collider>();
        zoneCollider.isTrigger = true;
        players = new List<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
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

    private void OnTriggerExit(Collider other)
    {
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