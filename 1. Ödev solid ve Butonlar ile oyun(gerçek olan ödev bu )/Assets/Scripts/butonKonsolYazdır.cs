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
    private int damage = 20;
    private int health = 120;
    private int sonCan;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("oyun başladı");
        rb = GetComponent<Rigidbody>();
        moveLeft = false;
        moveRight = false;


    }

    public class hasar
    {
        public int damage;
       public int lastcan;
        public int health;
        

        public hasar(int damageMiktarı)
        {
            damage = damageMiktarı;
            health= damageMiktarı;

        }

        public void GetDamage(int damage)
        {
            lastcan -= damage;
            if (lastcan <= 0)
            {
                Ölüm();
            }
        }

        private void Ölüm()
        {
            Debug.Log("öldün");
        }


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
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("move up");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("move Down");
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