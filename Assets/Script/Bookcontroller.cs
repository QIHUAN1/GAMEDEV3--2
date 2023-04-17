using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcontroller : MonoBehaviour
{
    AvatarController avatarController;

    public GameObject bookSign;
    
    public bool canUseit;
    public GameObject bookUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
       avatarController = GameObject.Find("Avatar").GetComponent<AvatarController>();

        canUseit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(canUseit == true && Input.GetKeyDown(KeyCode.E))
        {
            bookSign.SetActive(false);
            bookUI.SetActive(false);
            canUseit = false;
            avatarController.canMove = false;
        }



    }

    public void CanUse()

    {
        canUseit = true;
    }

    
}
