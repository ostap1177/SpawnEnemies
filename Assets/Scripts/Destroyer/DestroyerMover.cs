using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerMover : MonoBehaviour
{
    [SerializeField] private Transform[] _transformsPoint;
    [SerializeField] private float _speed;

    private Transform _transform;
    private int _targetIndex = 0;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        _transform.position = Vector3.MoveTowards(_transform.position, _transformsPoint[_targetIndex].position, _speed * Time.deltaTime);

        if (_transform.position == _transformsPoint[_targetIndex].position)
        {
            _targetIndex++;

            if (_targetIndex >= _transformsPoint.Length)
            {
                _targetIndex = 0;
            }
        }
    }
}
