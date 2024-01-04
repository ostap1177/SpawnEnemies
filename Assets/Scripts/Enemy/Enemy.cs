using UnityEngine;


public class Enemy : MonoBehaviour
{
    protected Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    public virtual void SetTarget(Transform position)
    {
        _mover.SetTarget(position);
    }
}
