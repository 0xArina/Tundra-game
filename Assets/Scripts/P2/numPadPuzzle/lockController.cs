using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lockController : MonoBehaviour
{

    private Image first;
    private Image second;
    private Image third;
    private Image fourth;

    //public GameObject lockButton;

    public Sprite zero;
    public Sprite two;
    public Sprite four;
    public Sprite nine;

    private bool unlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        first = GameObject.Find("firstNum").GetComponent<Image>();
        second = GameObject.Find("secondNum").GetComponent<Image>();
        third = GameObject.Find("thirdNum").GetComponent<Image>();
        fourth = GameObject.Find("fourthNum").GetComponent<Image>();

        //lockButton = GameObject.Find("lockButton").GetComponent<Image
    }

    // Update is called once per frame
    void Update()
    {
        if(first.sprite == nine && second.sprite == four && third.sprite == two && fourth.sprite == zero)
        {
            Debug.Log("Clicked and unlocked");
            SceneManager.LoadScene(8);
        }
    }

    //public void OnMouseDown()
    //{
    //    Debug.Log("Clicked");
    //    if(unlocked == true)
    //    {
    //        Debug.Log("Clicked and unlocked");
    //        SceneManager.LoadScene(8);
    //    }
    //}
}
