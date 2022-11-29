using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    [SerializeField] float speed=50.5f;
    // Start is called before the first frame update
    void Start()
    {
        float yy = Random.Range(-5.0f, 5.0f);
        transform.position = new Vector3(transform.position.x, yy, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < -12)
        {
            float yy = Random.Range(-5.0f, 5.0f);

            transform.position = new Vector3(12, yy, transform.position.z);
        }
        else 
        {
            transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
        }
        
    }
}
