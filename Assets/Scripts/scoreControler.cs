using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreControler : MonoBehaviour
{
    [SerializeField]playerEventController eventController;
    //[SerializeField] ;
    // Start is called before the first frame update

    private void addPoint()
    { }
    void Start()
    {
        eventController.onPointEarnedEvent.AddListener(addPoint);
    }

    // Update is called once per frame
    void Awake()
    {
        
    }
}
