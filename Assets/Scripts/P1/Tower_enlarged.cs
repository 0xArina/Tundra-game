﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tower_enlarged : MonoBehaviour
{
    public GameObject imageTower;
    public GameObject puzzleBG;
    

    public void Start()
    {
        imageTower.SetActive(false);
    }

    public void OnMouseEnter()
    {
        imageTower.SetActive(true);
        Debug.Log("Ray hit tower");
    }

    public void OnMouseDown()
    {
        //SceneManager.LoadScene(8);
        puzzleBG.SetActive(true);
    }

    public void OnMouseExit()
    {
        imageTower.SetActive(false);
    }
}