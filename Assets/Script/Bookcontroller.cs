using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcontroller : MonoBehaviour
{
    AvatarController avatarController;

    public GameObject bookSign;

    public GameObject theBook;
    
    public bool canUseit;
    public GameObject bookUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
       avatarController = GameObject.Find("Avatar").GetComponent<AvatarController>();

        canUseit = false;

        theBook.SetActive(false);
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

            theBook.SetActive(true);
        }

        else if (canUseit == false && Input.GetKeyDown(KeyCode.E))
        {
            bookUI.SetActive(true);
            canUseit = true;
            avatarController.canMove = true;

            theBook.SetActive(false);
        }



    }

    public void CanUse()

    {
        canUseit = true;
    }

    
}
