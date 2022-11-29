using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerEventController : MonoBehaviour
{
    public UnityEvent onJumpEvent;
    public UnityEvent onFallEvent;
    public UnityEvent onDeath;

    [SerializeField] float maxWidth = 6.0f;

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
            onFallEvent?.Invoke();
        }
        if (transform.position.y <= -4.5f)
        {
            onDeath?.Invoke();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "rura")
        {
            onDeath?.Invoke();
        }
        else if (other.tag == "PointColider")
        { 
            
        }
    }
}
