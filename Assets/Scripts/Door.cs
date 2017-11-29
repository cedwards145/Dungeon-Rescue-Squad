using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Switch controllingSwitch;
    public Transform openPosition;
    public Transform closePosition;
    public Transform doorModel;

    public float easingSpeed = 1;
    private float easingProgress = 0;
    private Easing.Ease ease;
    private Easing.Ease easeIn;
    private Easing.Ease easeOut;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (controllingSwitch.IsOn())
        {
            easingProgress = Mathf.Clamp(easingProgress + Time.deltaTime * easingSpeed, 0, 1);
        }
        else
        {
            easingProgress = Mathf.Clamp(easingProgress - Time.deltaTime * easingSpeed, 0, 1);
        }

        float x = Easing.EaseOutCubic(closePosition.position.x, openPosition.position.x, easingProgress);
        float y = Easing.EaseOutCubic(closePosition.position.y, openPosition.position.y, easingProgress);
        float z = Easing.EaseOutCubic(closePosition.position.z, openPosition.position.z, easingProgress);

        doorModel.position = new Vector3(x, y, z);
    }
}