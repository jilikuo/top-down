using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    EntityStats entity_stats;
    public GameObject target_object;

    // Start is called before the first frame update
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();
        target_object = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        FollowPlayer();

    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target_object.transform.position, entity_stats.base_speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<EntityStats>().hp -= entity_stats.attack_damage;
            entity_stats.hp -= entity_stats.max_hp;
        }
    }
}