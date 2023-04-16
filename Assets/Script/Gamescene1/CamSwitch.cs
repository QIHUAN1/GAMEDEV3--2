using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CamSwitch : MonoBehaviour
{
    public GameObject sign;
    public bool isInteracted;

    public GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        sign.SetActive(false);
        isInteracted = false;

        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInteracted == true)
        {
            sign.SetActive(true);

            cam2.SetActive(true);

        }

        else
        {
            sign.SetActive(false);

            cam2.SetActive(false);

        }


        if (isInteracted == true && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(3);
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
