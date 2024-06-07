using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public float max_hp;
    public float hp;
    public float base_speed;
    public float attack_damage;
    public float attack_speed;

    private void Start()
    {
        hp = max_hp;
    }

    private void FixedUpdate()
    {
        Death();
    }

    void Death()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }


}
