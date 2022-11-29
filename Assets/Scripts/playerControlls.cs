using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlls : MonoBehaviour
{
    IVelocity velocity;
    [SerializeField] float up = 5.0f;

    void Start()
    {
        velocity = gameObject.GetComponent<IVelocity>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.SetVelocity(Vector2.up * up);
        }
    }
}
