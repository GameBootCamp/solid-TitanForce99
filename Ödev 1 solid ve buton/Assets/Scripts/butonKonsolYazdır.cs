using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class butonKonsolYazdır : MonoBehaviour
{
    private Rigidbody rb;
    private bool moveLeft;
    private bool moveRight;
    private bool moveUp;
    private bool shoot;
    private float horizontalMove;
    private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("oyun başladı");
        rb = GetComponent<Rigidbody>();
        moveLeft = false;
        moveRight = false;


    }

    public void button2Click()
    {
        Debug.Log("ateş et");
    }

    public void buttonClick()
    {
        Debug.Log("zıpla");
    }



    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    private void MovementPlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
            Debug.Log("sola git");
        }

        else if(moveRight)
        {
            horizontalMove = speed;
            Debug.Log("sağ git");
        }

        else
        {
            horizontalMove = 0;
        }

        



    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

}