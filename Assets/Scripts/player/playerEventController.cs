using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class playerEventController : MonoBehaviour
{
    public UnityEvent onJumpEvent;
    public UnityEvent onFallEvent;
    public UnityEvent onDeathEvent;
    public UnityEvent onPointEarnedEvent;

    [SerializeField] float maxWidth = 6.0f;
    [SerializeField] int points = 1;
    [SerializeField] TextMeshPro textMesh;

    private IVelocity velocityComp;
    private bool jumping;

    private Vector2 prevVelocity;
    private void Start()
    {
        velocityComp = GetComponent<IVelocity>();
        jumping = false;
        prevVelocity = Vector2.zero;
    }
    
    void Update()
    {
        Vector2 velocity = velocityComp.GetVelocity();
        if(velocity.y > 0 && !jumping)
        {
            jumping = true;
            onJumpEvent?.Invoke();
        }
        if(velocity.y < 0 && jumping)
        {
            jumping = false;
            onFallEvent?.Invoke();
        }
        if (transform.position.y <= -4.5f)
        {
            onDeathEvent?.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        //Debug.Log("punkt");
        if (other.tag == "rura")
        {
            Debug.Log("rura");
            onDeathEvent?.Invoke();
        }
        else if (other.tag == "PointColider")
        {
            Debug.Log("punkt zdobyty");
            onPointEarnedEvent?.Invoke();
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("punkt2");
    //    if (collision.collider.tag == "rura")
    //    {
    //        onDeathEvent?.Invoke();
    //    }
    //    else if (collision.collider.tag == "PointColider")
    //    {
    //        onPointEarnedEvent?.Invoke();

    //    }
    //}
}
