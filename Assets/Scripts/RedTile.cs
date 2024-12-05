using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedTile : MonoBehaviour, IInteractable
{
    [SerializeField] private Sprite spriteInactive;
    [SerializeField] private Sprite spriteActive;
    private SpriteRenderer spriteRenderer;
    public float moveSpeed = 3f;
    private bool isMoving = false;
    private Vector3 moveDirection;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Interact()
    {
        float playerY = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        moveDirection = (playerY < transform.position.y) ? Vector3.up : Vector3.down;

        if (!isMoving)
        {
            StartCoroutine(MoveVertically(moveDirection));
        }
    }

    private IEnumerator MoveVertically(Vector3 moveDirection)
    {
        isMoving = true;
        this.moveDirection = moveDirection;
        while (isMoving)
        {
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<InteractionSystem>().SetInteractible(this);
            SetTileActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<InteractionSystem>().UnsetInteractable(this);
            SetTileActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        print("Collided with " + collision.gameObject.name );
        if (collision.gameObject.CompareTag("Obstacles")){
            isMoving = false;
            transform.position += -0.05f * moveDirection;
        }
    }

    private void SetTileActive(bool isActive)
    {
        if (isActive)
        {
            spriteRenderer.sprite = spriteActive;
        }
        else
        {
            spriteRenderer.sprite = spriteInactive;
        }
    }
}
