using UnityEngine;

public interface IController
{
    Vector3 GetMovementDirection();
    bool IsInteracting();
    bool IsAttacking();
}