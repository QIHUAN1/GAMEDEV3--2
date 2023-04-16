using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcontroller : MonoBehaviour
{
    public bool canUseit;
    
    // Start is called before the first frame update
    void Start()
    {
        canUseit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CanUse()

    {
        canUseit = true;
    }
}
