using System;
using Unity.VisualScripting;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float speed = .5f;
    public Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        transform.Translate(0, speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
             
        }
        else if (other.gameObject.tag == "EnemyShipBase")
        {
            
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
