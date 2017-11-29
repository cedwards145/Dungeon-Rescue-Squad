using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float lerpProgress;
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Update()
    {
        lerpProgress = Mathf.Clamp(lerpProgress + Time.deltaTime, 0, 1);
        float x = Easing.EaseInOutQuad(startPosition.x, endPosition.x, lerpProgress);
        float y = Easing.EaseInOutQuad(startPosition.y, endPosition.y, lerpProgress);
        float z = Easing.EaseInOutQuad(startPosition.z, endPosition.z, lerpProgress);

        transform.position = new Vector3(x, y, z);
    }

    public void MoveTo(Vector3 newPosition)
    {
        startPosition = transform.position;
        endPosition = newPosition;
        lerpProgress = 0;
    }
}
