using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.TryGetComponent<Mover>(out Mover mover) == true)
        {
            Destroy(otherCollider.gameObject);
        }
    }
}