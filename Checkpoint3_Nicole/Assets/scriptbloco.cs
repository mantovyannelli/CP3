using UnityEngine;

public class scriptbloco : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bola")
        {
            Destroy(gameObject, 0f);
        }

    }
}