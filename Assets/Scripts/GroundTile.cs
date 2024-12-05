using UnityEngine;

public class GroundTile : MonoBehaviour
{
    public Sprite unvisitedSprite;
    public Sprite visitedSprite;
    private SpriteRenderer spriteRenderer;
    private bool isVisited = false;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = unvisitedSprite;
    }

    private void Start() {
        GameManager.Instance.AddGroundTile(this);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isVisited)
        {
            VisitTile();
        }
    }

    private void VisitTile()
    {
        isVisited = true;
        spriteRenderer.sprite = visitedSprite;
        GameManager.Instance.RemoveGroundTile(this);
    }
}
