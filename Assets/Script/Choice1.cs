using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice1 : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("ans1-1");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("ans1-2");
        }
    }

}
