using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.TryGetComponent(out Mover mover) == true)
        {
            Destroy(otherCollider.gameObject);
        }
    }
}