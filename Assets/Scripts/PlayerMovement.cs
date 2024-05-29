using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float base_speed;
    float diagonal_nerf;
    float move_speed;

    // Start is called before the first frame update
    void Start()
    {
        move_speed = base_speed;
        diagonal_nerf = 0.66f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        WASDMove();

    }

    void WASDMove()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontal * move_speed, vertical * move_speed));

        if (horizontal != 0 && vertical != 0)
        {
            move_speed = base_speed * diagonal_nerf;
        }

    }
}