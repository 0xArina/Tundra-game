using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class puzzle2Controller : MonoBehaviour
{

    private Image first;
    private Image second;
    private Image third;
    private Image fourth;
    private Image fifth;

    public Sprite p;
    public Sprite f;
    public Sprite m;
    public Sprite b;
    public Sprite y;

    public GameObject passCode;

    public GameObject backButtonStart;
    public GameObject backButtonEnd;

    // Start is called before the first frame update
    void Start()
    {
        first = GameObject.Find("firstCode").GetComponent<Image>();
        second = GameObject.Find("secondCode").GetComponent<Image>();
        third = GameObject.Find("thirdCode").GetComponent<Image>();
        fourth = GameObject.Find("fourthCode").GetComponent<Image>();
        fifth = GameObject.Find("fifthCode").GetComponent<Image>();

        backButtonEnd.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (first.sprite == f && second.sprite == y && third.sprite == b && fourth.sprite == m && fifth.sprite == p)
        {
            passCode.SetActive(true);
            backButtonStart.SetActive(false);
            backButtonEnd.SetActive(true);
        }
        else
        {
            passCode.SetActive(false);
            backButtonStart.SetActive(true);
        };
    }
}

