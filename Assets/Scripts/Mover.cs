using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _destroyerTarget;
    private Enemy _enemy;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _destroyerTarget = _enemy.TargetPosition;
    }

    private void Update()
    {
        transform.position =  Vector3.MoveTowards(transform.position, _destroyerTarget, _speed * Time.deltaTime);
    }
}
