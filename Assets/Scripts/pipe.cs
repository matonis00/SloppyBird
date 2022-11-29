using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    [SerializeField] float speed=50.5f;
    // Start is called before the first frame update
    void Start()
    {
        float yy = Random.Range(-2.0f, 2.0f);
        transform.position = new Vector3(transform.position.x, yy, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < -16)
        {
            float yy = Random.Range(-2.0f, 2.0f);

            transform.position = new Vector3(16, yy, transform.position.z);
        }
        else 
        {
            transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
        }
        
    }
}
