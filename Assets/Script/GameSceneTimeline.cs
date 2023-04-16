using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSceneTimeline : MonoBehaviour
{

    public GameObject Choice1;


    private void Start()
    {
        Choice1.SetActive(false);

    }

    public void choice1()
    {
        Choice1.SetActive(true);
    }

}
