using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnlargeSafe : MonoBehaviour
{
    public GameObject image;

    void Start()
    {
        image.SetActive(false);
    }

    private void OnMouseEnter()
    {
        image.SetActive(true);
    }

    private void OnMouseExit()
    {
        image.SetActive(false);
    }

    private void OnMouseDown()
    {
        //SceneManager.LoadScene()
    }
}
