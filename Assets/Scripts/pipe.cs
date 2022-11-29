using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    [SerializeField] float speed=50.5f;
    playerEventController eventController;
    bool movement=true;
    // Start is called before the first frame update
    void Start()
    {
        float yy = Random.Range(-2.0f, 2.0f);
        transform.position = new Vector3(transform.position.x, yy, transform.position.z);

        eventController = GameObject
            .FindGameObjectWithTag("Player")
            .GetComponent<playerEventController>();
        eventController.onDeathEvent.AddListener(onPlayerDeath);
    }

    // Update is called once per frame
    private void onPlayerDeath()
    {
       movement = false;
    }
    void Update()
    {
        
        if (transform.position.x < -14)
        {
            float yy = Random.Range(-2.5f, 2.5f);

            transform.position = new Vector3(22, yy, transform.position.z);
        }
        else if(movement) 
        {
            transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
        }
        
    }
}
