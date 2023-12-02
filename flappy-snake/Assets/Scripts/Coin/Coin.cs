using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Action CoinPickedUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            CoinPickedUp?.Invoke();
            Destroy(gameObject);
        }
    }
}