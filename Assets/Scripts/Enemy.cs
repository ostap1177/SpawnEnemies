using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _targetPosition;

    public Vector3 TargetPosition => _targetPosition;

    public void SetTarget(Vector3 position)
    {
        _targetPosition = position;
    }
}
