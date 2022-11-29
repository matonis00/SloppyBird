using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float up=5.0f;
    [SerializeField] float maxWidth=6.0f;
    Rigidbody2D rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& transform.position.y < maxWidth)
        {
            rigidbody2D.AddForce(Vector2.up*up);
        }
        if (transform.position.y <= -4.5f)
        {
            rigidbody2D.Sleep();
        }
    }
}
