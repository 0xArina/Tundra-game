using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKeyCollected : MonoBehaviour
{

    public GameObject key;
    public static bool keyActive;

    // Update is called once per frame
    void Update()
    {
        if(keyActive == true)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
        }
    }
}
