using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D Rigidbody;

    private Vector2 moveDirection;
    private bool canMove;
    private Vector2 still = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        

        //if we can move we do so here
        if (canMove)
        {
            ProcessInputs();
        }
        else if (Rigidbody.velocity == still)
        {
            canMove = true;
        }
    }

    private void FixedUpdate()
    {
        //Rigidbody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void ProcessInputs()
    {
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);

        if (left)
        {
            if (Rigidbody.velocity != still) canMove = false;
            Rigidbody.velocity = still;
            Rigidbody.AddForce(new Vector2(-moveSpeed, 0));
        }
        if (right)
        {
            if (Rigidbody.velocity != still) canMove = false;
            Rigidbody.velocity = still;
            Rigidbody.AddForce(new Vector2(moveSpeed, 0));
        }
        if (up)
        {
            if (Rigidbody.velocity != still) canMove = false;
            Rigidbody.velocity = still;
            Rigidbody.AddForce(new Vector2(0, moveSpeed));
        }
        if (down)
        {
            if (Rigidbody.velocity != still) canMove = false;
            Rigidbody.velocity = still;
            Rigidbody.AddForce(new Vector2(0, -moveSpeed));
        }
    }

    void Move(Vector2 direction)
    {
        moveDirection = direction;
    }
}
