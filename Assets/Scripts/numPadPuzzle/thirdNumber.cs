using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class thirdNumber : MonoBehaviour
{
    private Image third;

    private int counter = 0;

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
        third = GameObject.Find("thirdNum").GetComponent<Image>();
    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            third.sprite = one;
            counter++;
        }
        else if (counter == 1)
        {
            third.sprite = two;
            counter++;
        }
        else if (counter == 2)
        {
            third.sprite = three;
            counter++;
        }
        else if (counter == 3)
        {
            third.sprite = four;
            counter++;
        }
        else if (counter == 4)
        {
            third.sprite = five;
            counter++;
        }
        else if (counter == 5)
        {
            third.sprite = six;
            counter++;
        }
        else if (counter == 6)
        {
            third.sprite = seven;
            counter++;
        }
        else if (counter == 7)
        {
            third.sprite = eight;
            counter++;
        }
        else if (counter == 8)
        {
            third.sprite = nine;
            counter++;
        }
        else if (counter == 9)
        {
            third.sprite = zero;
            counter = 0;
        }

    }
}
