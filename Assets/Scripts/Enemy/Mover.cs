using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;
    private Transform _destroyerTarget;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        _transform.position =  Vector3.MoveTowards(_transform.position, _destroyerTarget.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Transform destroyerPosition)
    {
        _destroyerTarget = destroyerPosition;
    }
}
