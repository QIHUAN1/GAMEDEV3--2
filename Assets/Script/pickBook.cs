using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickBook : MonoBehaviour
{

    public GameObject sign;
    public bool isInteracted;

    // Start is called before the first frame update
    void Start()
    {
        sign.SetActive(false);
        isInteracted = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isInteracted == true)
        {
            sign.SetActive(true);
        }

        else
        {
            sign.SetActive(false);
        }

        if (isInteracted == true && Input.GetKeyDown(KeyCode.F))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInteracted = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInteracted = false;
        }

    }
}
