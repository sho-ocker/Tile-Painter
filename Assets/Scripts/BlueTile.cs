using System.Collections;
using UnityEngine;

public class BlueTile : MonoBehaviour, IInteractable
{
    [SerializeField] private Sprite spriteInactive;
    [SerializeField] private Sprite spriteActive;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Interact()
    {
        StartCoroutine(FadeOutAndDestroy());
    }

    private IEnumerator FadeOutAndDestroy()
    {
        print("Interacted");
        float duration = 1.0f; // Duration in seconds over which the tile fades out
        float elapsed = 0;

        while (elapsed < duration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsed / duration);
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
            elapsed += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
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
