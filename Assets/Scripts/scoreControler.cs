using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreControler : MonoBehaviour
{
    [SerializeField]playerEventController eventController;
    [SerializeField] TextMeshProUGUI textMesh;
    // Start is called before the first frame update

    [SerializeField] int points = 0;

    private void addPoint()
    {
        //TextMeshPro textMesh = gameObject.GetComponent<TextMeshPro>();
        points++;
        textMesh.text = points.ToString();
    }
    void Start()
    {
        eventController.onPointEarnedEvent.AddListener(addPoint);
    }

    // Update is called once per frame
    void Awake()
    {
        
    }
}
