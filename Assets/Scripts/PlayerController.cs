using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float dirX, dirY;
    public bool isf = false;
    [SerializeField]
    public float speed;

    private Rigidbody rb;
    private Animator anim;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //управление и движение 
        dirX = joystick.Horizontal * speed;
        dirY= joystick.Horizontal * speed;

        if (dirX > 0 && !isf)
        {
            Flip();
        }
        else if(dirX < 0 && isf)
        {
            Flip();
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
}
