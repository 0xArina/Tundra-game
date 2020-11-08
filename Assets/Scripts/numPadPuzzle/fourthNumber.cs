using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class fourthNumber : MonoBehaviour
{
    private Image fourth;

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
        fourth = GameObject.Find("fourthNum").GetComponent<Image>();
    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            fourth.sprite = one;
            counter++;
        }
        else if (counter == 1)
        {
            fourth.sprite = two;
            counter++;
        }
        else if (counter == 2)
        {
            fourth.sprite = three;
            counter++;
        }
        else if (counter == 3)
        {
            fourth.sprite = four;
            counter++;
        }
        else if (counter == 4)
        {
            fourth.sprite = five;
            counter++;
        }
        else if (counter == 5)
        {
            fourth.sprite = six;
            counter++;
        }
        else if (counter == 6)
        {
            fourth.sprite = seven;
            counter++;
        }
        else if (counter == 7)
        {
            fourth.sprite = eight;
            counter++;
        }
        else if (counter == 8)
        {
            fourth.sprite = nine;
            counter++;
        }
        else if (counter == 9)
        {
            fourth.sprite = zero;
            counter = 0;
        }

    }
}

