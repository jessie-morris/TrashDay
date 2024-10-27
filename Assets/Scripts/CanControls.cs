using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanControls : MonoBehaviour
{
    [SerializeField] private Sprite[] canSprites;
    [SerializeField] private Sprite[] playerSprites;
    [SerializeField] private GameObject player;
    private SpriteRenderer playerSpriteRenderer;

    private float speed = 8;
    private SpriteRenderer spriteRenderer;
    private int spriteIndex = 0;


    enum CanState
    {
        Recycling,
        Compost,
        Trash
    }

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();

        AudioManager.instance.Play("CleanupTheme");
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal != 0)
        {
            float newX = Mathf.Clamp(transform.position.x + (horizontal * speed * Time.deltaTime), -7.25f, 7.25f);
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
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        tag = other.tag;
        bool match = CanMatchTrash((CanState)spriteIndex, tag);
        if (match)
        {
            CreditsManager.instance.AddToScore(150);
            AudioManager.instance.PlayOneShot("Success");
        }
        else
        {
            AudioManager.instance.PlayOneShot("Failure");
            StartCoroutine(ShakeHead());
            //Can we do an animation for this?
            CreditsManager.instance.DeductFromScore(50);
        }
        Destroy(other.gameObject);
    }

    bool CanMatchTrash(CanState state, string tag)
    {

        if (state == CanState.Recycling && tag == "Recyclable")
        {
            return true;
        }
        if (state == CanState.Compost && tag == "Compost")
        {
            return true;
        }
        if (state == CanState.Trash && tag == "Trash")
        {
            return true;
        }
        return false;
    }

    IEnumerator ShakeHead()
    {
        playerSpriteRenderer.sprite = playerSprites[1];
        yield return new WaitForSeconds(0.1f);
        playerSpriteRenderer.sprite = playerSprites[2];
        yield return new WaitForSeconds(0.1f);
        playerSpriteRenderer.sprite = playerSprites[1];
        yield return new WaitForSeconds(0.1f);
        playerSpriteRenderer.sprite = playerSprites[2];
        yield return new WaitForSeconds(0.1f);
        playerSpriteRenderer.sprite = playerSprites[0];
        yield return null;
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
