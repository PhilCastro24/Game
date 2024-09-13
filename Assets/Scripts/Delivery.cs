using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    TimerController Timer;

    bool hasPizza;

    [SerializeField] float destroyDelay;
    [SerializeField] Color32 noPizzaColor = new Color32(1, 1, 1, 255);
    [SerializeField] Color32 hasPizzaColor = new Color32(1, 1, 1, 255);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        Timer = FindObjectOfType<TimerController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Customer")&& hasPizza)
        {
            Debug.Log("Pizza delivered!");
            hasPizza = false;
            Timer.ResetTimer();
            spriteRenderer.color = noPizzaColor;
        }

        if (collider.gameObject.CompareTag("Pickup") && !hasPizza)
        {
            Debug.Log("Pizza picked up");
            Destroy(collider.gameObject, destroyDelay);
            hasPizza = true;
            spriteRenderer.color = hasPizzaColor;
            Timer.ResetTimer();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player collided with Obstacle");
        }
    }
}
