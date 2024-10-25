using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanControls : MonoBehaviour
{
    public Sprite[] canSprites;

    private float speed = 8;
    private SpriteRenderer spriteRenderer;
    private int spriteIndex = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal != 0)
        {
            float newX = Mathf.Clamp(transform.position.x + (horizontal * speed * Time.deltaTime), -8f, 8f);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RotateThroughCans();
        }
    }
    void RotateThroughCans()
    {
        spriteIndex++;
        if (spriteIndex >= canSprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = canSprites[spriteIndex];

        GameManager.instance.UpdateScore();
    }

    // private Vector3 BoundToScreen(Vector3 newPosition)
    // {
    //     float halfWidth = spriteRenderer.sprite.bounds.size.x;
    //     float halfHeight = spriteRenderer.sprite.bounds.size.y;

    //     newPosition.x = Mathf.Clamp(newPosition.x, screenBounds.x * -1 + halfWidth, screenBounds.x - halfWidth);
    //     newPosition.y = Mathf.Clamp(newPosition.y, screenBounds.y * -1 + halfHeight, screenBounds.y - halfHeight);
    //     return newPosition;
    // }
}
