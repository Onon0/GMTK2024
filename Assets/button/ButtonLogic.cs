using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ButtonLogic : MonoBehaviour
{
    public Sprite default_sprite;
    public Sprite pressed_sprite;
    private GameObject GameManager;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision == null) return;
        spriteRenderer.sprite = pressed_sprite;
        
        GameManager.GetComponent<GameManagerScript>().Finish();
    }
}
