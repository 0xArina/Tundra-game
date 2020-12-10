using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story2_ImgOrder : MonoBehaviour
{

    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public GameObject img7;

    // Start is called before the first frame update
    void Start()
    {
        // hide all imgs but 1
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
        img7.SetActive(false);

        // call functions each second 
        Invoke("ShowImg2", 1.0f);
        Invoke("ShowImg3", 2.0f);
        Invoke("ShowImg4", 3.0f);
        Invoke("ShowImg5", 4.0f);
        Invoke("ShowImg6", 5.0f);
        Invoke("ShowImg7", 6.0f);
    }

    void ShowImg2()
    {
        img2.SetActive(true);
    }

    void ShowImg3()
    {
        img3.SetActive(true);
    }

    void ShowImg4()
    {
        img4.SetActive(true);
    }

    void ShowImg5()
    {
        img5.SetActive(true);
    }

    void ShowImg6()
    {
        img6.SetActive(true);
    }

    void ShowImg7()
    {
        img7.SetActive(true);
    }

}

