using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    public string PlayerTag;

    public Collider2D ball;

    public Collider2D PuLongPaddleController;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // move object
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            // gerakan ke atas
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            // gerakan ke bawah
            return Vector2.down * speed;

        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }


    public void PuLongPaddle()
    {
        transform.localScale = new Vector3(0.3f, 4, 1);
        Invoke("PuNormalLongPaddle", 5);
    }

    public void PuNormalLongPaddle()
    {
        transform.localScale = new Vector3(0.3f, 2, 1);
    }

    public void PuSpeedUpPaddle()
    {
        speed *= 2;
        Invoke("PuNormalSpeedUpPaddle", 5);
    }

    public void PuNormalSpeedUpPaddle()
    {
        speed = 8;
    }
}
