using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    bool[] condition = new bool[3];
    public GameObject[] lightEffect;

    public void LightSetting(int number)
    {
        condition[number] = !condition[number];

        lightEffect[number].SetActive(condition[number]);
    }
    void Start()
    {
        condition[0] = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}