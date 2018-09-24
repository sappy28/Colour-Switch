using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public string CurrentColor;
    public float JumpForce = 10f;
    public Rigidbody2D circle;
    public SpriteRenderer Sprite;
    public Color blue;
    public Color yellow;
    public Color pink;
    public Color purple;

    void Start ()
    {
        SetRandomColor();
	}
	
	void Update ()
    {
        if( Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) )
        {
            circle.velocity = Vector2.up * JumpForce;
        }
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != CurrentColor)

        Debug.Log("You are Dead");
    }

    void SetRandomColor()
    {
        int rand = Random.Range(0, 4);

        switch (rand)
        {
            case 0:
                CurrentColor = "Blue";
                Sprite.color = blue;
                break;

            case 1:
                CurrentColor = "Yellow";
                Sprite.color = yellow;
                break;

            case 2:
                CurrentColor = "Pink";
                Sprite.color = pink;
                break;

            case 3:
                CurrentColor = "Purple";
                Sprite.color = purple;
                break;
        }
    }
}
