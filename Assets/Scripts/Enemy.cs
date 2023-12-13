using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 TargetPosition { get; private set;}

    public void SetTarget(Vector3 position)
    {
        TargetPosition = position;
    }
}
