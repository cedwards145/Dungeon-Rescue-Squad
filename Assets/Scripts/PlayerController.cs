using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IController))]
public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    private IController controller;
    private new Camera camera;
    private LevelController levelController;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<IController>();
        levelController = FindObjectOfType<LevelController>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = controller.GetMovementDirection();
        moveDirection = Quaternion.AngleAxis(camera.transform.rotation.eulerAngles.y, Vector3.up) * moveDirection;

        transform.LookAt(transform.position + moveDirection);
        transform.Translate(Vector3.forward * moveDirection.magnitude * speed * Time.deltaTime);
    }

    public void Kill()
    {
        levelController.Restart();
    }
}