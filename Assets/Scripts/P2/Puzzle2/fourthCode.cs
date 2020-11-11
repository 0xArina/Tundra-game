using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class fourthCode : MonoBehaviour
{
    private Image fourth;

    private int counter = 4;

    public Sprite f;
    public Sprite y;
    public Sprite b;
    public Sprite m;
    public Sprite p;

    void Start()
    {
        fourth = GameObject.Find("fourthCode").GetComponent<Image>();

    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            fourth.sprite = p;
            counter++;
        }
        else if (counter == 1)
        {
            fourth.sprite = f;
            counter++;
        }
        else if (counter == 2)
        {
            fourth.sprite = m;
            counter++;
        }
        else if (counter == 3)
        {
            fourth.sprite = b;
            counter++;
        }
        else if (counter == 4)
        {
            fourth.sprite = y;
            counter = 0;
        }

    }
}
