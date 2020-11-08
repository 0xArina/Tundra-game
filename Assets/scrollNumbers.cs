using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class scrollNumbers : MonoBehaviour
{
    public Image first;
    //private int counter = 0;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;

    void Start()
    {
        first = GameObject.Find("firstNum").GetComponent<Image>();
    }

    public void OnMouseDown()
    {
        
        first.sprite = one;
       
    }
}
