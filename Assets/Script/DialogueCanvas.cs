using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCanvas : MonoBehaviour
{
    public Animator animator;

    public GameObject sightTool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoAnswer1()
    {
        animator.SetTrigger("ans1-3");
    }

    public void UnlocktheTool()
    {
        sightTool.SetActive(true);
    }
}
