using System.Collections.Concurrent;
using Unity.VisualScripting;
using UnityEngine;

public class recuperamoabola : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    float moverx;
    float movery;
    float velocidade = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        moverx = Random.Range(-9.65f, 9.65f);
        movery = Random.Range(-4.65f, 4.65f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((moverx * Time.deltaTime), (movery  * Time.deltaTime), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bloco")
        {
            moverx = (-moverx + 1);
            movery = (-movery + 1);

        }
        if (collision.tag == "paredex")
        {
            moverx = (-moverx + 1);
            movery = (-movery + 1);


        }
        if (collision.tag == "paredey")
        {
            moverx = (-moverx + 1);
            movery = (-movery + 1);


        }
        if (collision.tag == "t")
        {
            moverx = (-moverx + 1);
            movery = (-movery + 1);

        }
    }

}

