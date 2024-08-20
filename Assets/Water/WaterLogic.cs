using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLogic : MonoBehaviour
{
    Rigidbody2D rb2d;
    private void Update()
    {
        if (rb2d == null) return;

        if (rb2d.mass == 0.2f)
        {
            rb2d.gravityScale = 0f;
            rb2d.velocity = Vector2.up;
        }
        if (rb2d.mass == 0.5f)
        {
            rb2d.gravityScale = 0f;
            rb2d.velocity = Vector2.up * 0.5f;
        }
        if (rb2d.mass == 1f)
        {
            rb2d.gravityScale = 0.2f;

        }
        if (rb2d.mass == 2f)
        {
            rb2d.gravityScale = 1f;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player") return;
        
        rb2d = collision.gameObject.GetComponent<Rigidbody2D>();
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player") return;
        rb2d.gravityScale = 2;
        rb2d.velocity = Vector2.zero;
        rb2d = null;


    }
}
