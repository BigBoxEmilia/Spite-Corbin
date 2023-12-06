using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealAttackArea : MonoBehaviour
{




    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<AttributesManager>() != null)
        {
            AttributesManager health = collider.GetComponent<AttributesManager>();
            health.Damage(3);
        }
    }
}
