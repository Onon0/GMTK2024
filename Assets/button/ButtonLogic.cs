using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ButtonLogic : MonoBehaviour
{
    public Sprite default_sprite;
    public Sprite pressed_sprite;
    public SpriteRenderer face_sprite;
    public Sprite hit_face;
    private AudioSource SuccessSound;
    private GameObject GameManager;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        SuccessSound = GetComponent<AudioSource>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision == null) return;
        spriteRenderer.sprite = pressed_sprite;
        face_sprite.sprite = hit_face;
        SuccessSound.Play();
        GameManager.GetComponent<GameManagerScript>().Finish();
    }
}
