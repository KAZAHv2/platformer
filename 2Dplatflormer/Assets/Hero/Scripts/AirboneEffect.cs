﻿using System.Collections;
using UnityEngine;


public class AirboneEffect : MonoBehaviour
{
    private Rigidbody2D rb;
    private Movement move;
    public float airSpeed = 2f;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        move = GetComponent<Movement>();
        this.enabled = false;
    }

    void Update()
    {
        //if (!move.ground)
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, -airSpeed);
        //}
        SlowFallEffect();
    }

    void SlowFallEffect()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (!move.ground)
            {
                rb.velocity = new Vector2(rb.velocity.x, -airSpeed);
            }
        }
        else if(Input.GetKeyUp(KeyCode.F)) { }
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }
    }







    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AirboneOff"))
        {
            this.GetComponent<AirboneEffect>().enabled = false;
        }
        else if (collision.gameObject.CompareTag("AirboneOn"))
        {
            this.enabled = true;
        }
    }


}
