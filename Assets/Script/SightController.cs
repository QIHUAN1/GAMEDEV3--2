using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightController : MonoBehaviour
{
    public GameObject theImage;

    public GameObject theUI;
    public bool canUse;

    public bool sightMode;
    
    // Start is called before the first frame update
    void Start()
    {
        theImage.SetActive(false);
        theUI.SetActive(true);
        canUse = false;

        sightMode = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(canUse == false && Input.GetKeyDown(KeyCode.G))
        {
            theImage.SetActive(true);
            canUse = true;
            theUI.SetActive(false);
            sightMode = true;
        }

       else if (canUse == true && Input.GetKeyDown(KeyCode.G))
        {
            theImage.SetActive(false);
            canUse = false;
            theUI.SetActive(true);
            sightMode = false;
        }
    }
}
