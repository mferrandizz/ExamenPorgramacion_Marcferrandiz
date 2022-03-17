using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float vel = 5f;
    public float jumpForce = 10f;

    public bool isGrounded;

    float direccionX;

    public SpriteRenderer renderer;
    Rigidbody2D _rBody;


    void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Update()
    {
        direccionX = Input.GetAxisRaw("Horizontal");

       Debug.Log(direccionX);

       //transform.position += new Vector3(direccionX, 0, 0) * vel * Time.deltaTime;


       if(direccionX == -1)
       {
           renderer.flipX = true;
           Debug.Log(direccionX);
       }
       else if (direccionX == 1)
       {
           renderer.flipX = false;
           Debug.Log(direccionX);
       }

       if(Input.GetButtonDown("Jump") && isGrounded)
       {
           _rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
       }
    }

    void FixedUpdate()
    {
        _rBody.velocity = new Vector2(direccionX * vel, _rBody.velocity.y);
    }

}
