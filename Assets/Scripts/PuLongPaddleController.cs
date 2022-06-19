using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuLongPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D player1;
    public Collider2D player2;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            player1.GetComponent<PlayerController>().PuLongPaddle();
            player2.GetComponent<PlayerController>().PuLongPaddle();
            manager.RemovePowerUp(gameObject);
        }
    }
}
