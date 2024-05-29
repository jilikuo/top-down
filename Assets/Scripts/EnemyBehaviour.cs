using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public float move_speed;
    public GameObject target_object;

    // Start is called before the first frame update
    void Start()
    {

        target_object = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        FollowPlayer();

    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, target_object.transform.position, move_speed);
    }
}