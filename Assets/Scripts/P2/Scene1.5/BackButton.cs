﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(6);
    }
}
