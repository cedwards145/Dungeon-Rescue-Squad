using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisController : MonoBehaviour, IController
{
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 GetMovementDirection()
    {
        return new Vector3(Input.GetAxis(horizontalAxis), 0, Input.GetAxis(verticalAxis));
    }

    public bool IsAttacking()
    {
        return false;
    }

    public bool IsInteracting()
    {
        return false;
    }
}