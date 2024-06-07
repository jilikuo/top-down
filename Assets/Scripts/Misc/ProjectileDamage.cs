using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    public float projectile_damage;

    void Start()
    {
        Destroy(this.gameObject, 2); 
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EntityStats>().hp -= projectile_damage;
            Destroy(this.gameObject);
        }
    }
}
