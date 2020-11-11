using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hoverController : MonoBehaviour
{
    public GameObject image;

    public void Start()
    {
        image.SetActive(false);
    }

    public void OnMouseEnter() 
    {
        image.SetActive(true);
        Debug.Log("Ray hit something");
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene(7);
    }

    public void OnMouseExit()
    {
        image.SetActive(false);
    }
}
