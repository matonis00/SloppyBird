using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerMovement : MonoBehaviour, IVelocity
{
    [SerializeField] float up=5.0f;
    //[SerializeField] float maxWidth=6.0f;
    Rigidbody2D rigidbody2D;
    playerEventController eventController;
    bool dead = false;

    public Vector2 GetVelocity()
    {
        return rigidbody2D.velocity;
    }

    public void SetVelocity(Vector2 velocity)
    {   if(!dead)
        rigidbody2D.AddForce(velocity);
    }

    void Awake()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        eventController = gameObject.GetComponent<playerEventController>();
        eventController.onDeathEvent.AddListener(onDeath);
    }

    private void onDeath()
    {
        dead = true;
        rigidbody2D.Sleep();
    }
    
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space)&& transform.position.y < maxWidth)
    //    {
    //        //rigidbody2D.AddForce(Vector2.up*up);
    //    }
    //    if (transform.position.y <= -4.5f)
    //    {
    //        rigidbody2D.Sleep();
    //    }
    //}
}
