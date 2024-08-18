using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Color tiny_color;
    public Color small_color;
    public Color medium_color;
    public Color large_color;

    public Sprite tiny_sprite;
    public Sprite small_sprite;
    public Sprite medium_sprite;
    public Sprite large_sprite;

    public float tiny_mass;
    public float small_mass;
    public float medium_mass;
    public float large_mass;

    public SpriteRenderer face;
    
    private Vector3 tiny;
    private Vector3 small;
    private Vector3 medium;
    private Vector3 large;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        tiny = new Vector3(0.5f, 0.5f, 0.5f);
        small = new Vector3(1f, 1f, 1f);
        medium = new Vector3(2f, 2f, 2f);
        large = new Vector3(3f, 3f, 3f);
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
        setSmall();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) { rb.simulated = true; }
        if(Input.GetKeyDown(KeyCode.Q)) {
            setTiny();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            setSmall();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SetMedium();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SetLarge();
        }


    }

    public void SetLarge()
    {
        transform.localScale = large;
        sprite.color = large_color;
        face.sprite = large_sprite;
        rb.mass = large_mass;
    }

    public void setTiny()
    {
        transform.localScale = tiny;
        sprite.color = tiny_color;
        face.sprite = tiny_sprite;
        rb.mass = tiny_mass;
    }
    public void setSmall()
    {
        transform.localScale = small;
        sprite.color = small_color;
        face.sprite = small_sprite;
        rb.mass = small_mass;
    }
    public void SetMedium()
    {
        transform.localScale = medium;
        sprite.color = medium_color;
        face.sprite = medium_sprite;
        rb.mass = medium_mass;
    }

    
  
    public void Finish()
    {
        rb.simulated = false;
        
    }
    
}
