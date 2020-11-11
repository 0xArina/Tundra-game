using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class secondCode : MonoBehaviour
{
    private Image second;

    private int counter = 2;

    public Sprite f;
    public Sprite y;
    public Sprite b;
    public Sprite m;
    public Sprite p;

    void Start()
    {
        second = GameObject.Find("secondCode").GetComponent<Image>();

    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            second.sprite = p;
            counter++;
        }
        else if (counter == 1)
        {
            second.sprite = f;
            counter++;
        }
        else if (counter == 2)
        {
            second.sprite = m;
            counter++;
        }
        else if (counter == 3)
        {
            second.sprite = b;
            counter++;
        }
        else if (counter == 4)
        {
            second.sprite = y;
            counter = 0;
        }

    }
}
