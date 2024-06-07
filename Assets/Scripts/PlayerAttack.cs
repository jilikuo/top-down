using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projetil;
    EntityStats entity_stats;

    float cooldown_;
    bool can_attack;

    // Start is called before the first frame update
    void Start()
    {
        can_attack = true;
        cooldown_ = 0;
        entity_stats = gameObject.GetComponent<EntityStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && can_attack == true)
        {
            GameObject projectile_instance = Instantiate(projetil, transform.position, Quaternion.identity);

            projectile_instance.GetComponent<ProjectileDamage>().projectile_damage = entity_stats.attack_damage;

            Vector2 projectile_direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            projectile_direction.Normalize();

            projectile_instance.GetComponent<Rigidbody2D>().AddForce(projectile_direction * 10, ForceMode2D.Impulse);
            can_attack = false;
            cooldown_ = 0;
        }

        Cooldown();

    }

    void Cooldown()
    {

        if (cooldown_ > entity_stats.attack_speed && can_attack == false)
        {
            can_attack = true;
        }
        else
        {
            cooldown_ += Time.deltaTime;
        }

    }
}
