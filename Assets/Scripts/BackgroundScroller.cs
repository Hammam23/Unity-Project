using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Vector2 startPos;
    private float width;

    void Start()
    {
        startPos = transform.position;
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, width);
        transform.position = startPos + Vector2.left * newPos;
    }
}
