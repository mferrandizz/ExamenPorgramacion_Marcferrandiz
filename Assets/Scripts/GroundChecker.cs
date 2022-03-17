using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounCheker : MonoBehaviour
{
    public Player _player;

    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<Player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        _player.isGrounded = true;
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
    }
}

