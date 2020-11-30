using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (CheckKeyCollected.keyActive == true)
        {
            //LoadSceneMode scene behind door
            SceneManager.LoadScene(14);
        }
        else {
            counter++;
            doorLockedMessage.SetActive(true);
        }
    }

    private void Update()
    {
        if (counter % 2 == 0 || CheckKeyCollected.keyActive == true)
        {
            doorLockedMessage.SetActive(false);
        }
        else
        {
            doorLockedMessage.SetActive(true);
        }
    }
}
