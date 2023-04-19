using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class theLedderController : MonoBehaviour
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

            if(Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(5);
            }
        }

        else
        {
            sign.SetActive(false);
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
