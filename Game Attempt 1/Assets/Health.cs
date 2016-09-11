using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public float health = 100;

    public void Damage(float dmg)
    {
        health -= dmg;
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
