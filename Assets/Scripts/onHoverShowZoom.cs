using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class onHoverShowZoom : MonoBehaviour
{
    public GameObject image;

    public void Start()
    {
        image.SetActive(false);
    }

    public void OnMouseEnter()
    {
        image.SetActive(true);
    }

    public void OnMouseExit()
    {
        image.SetActive(false);
    }
}
