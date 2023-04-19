using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theLedderSight : MonoBehaviour
{
    public GameObject theControl;
    public GameObject theLadder;
    
    // Start is called before the first frame update
    void Start()
    {
        
        theLadder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(theControl.GetComponent<SightController>().sightMode == true)
        {
            theLadder.SetActive(true);
        }

        if (theControl.GetComponent<SightController>().sightMode == false)
        {
            theLadder.SetActive(false);
        }

    }
}
