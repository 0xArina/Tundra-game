using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorLockedPrompt : MonoBehaviour
{
    public GameObject doorLockedMessage;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        doorLockedMessage.SetActive(false);
    }

    private void OnMouseDown()
    {
        counter++; 
        doorLockedMessage.SetActive(true);
    }

    private void Update()
    {
        if (counter % 2 == 0)
        {
            doorLockedMessage.SetActive(false);
        }
        else
        {
            doorLockedMessage.SetActive(true);
        }
    }
}
