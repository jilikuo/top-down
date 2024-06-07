using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projetil;
    EntityStats entity_stats;

    // Start is called before the first frame update
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject projectile_instance = Instantiate(projetil, transform.position, Quaternion.identity);

            projectile_instance.GetComponent<ProjectileDamage>().projectile_damage = entity_stats.attack_damage;

            Vector2 projectile_direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            projectile_direction.Normalize();

            projectile_instance.GetComponent<Rigidbody2D>().AddForce(projectile_direction * 10, ForceMode2D.Impulse);
        }
    }
}
