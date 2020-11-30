using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToKeyScene1 : MonoBehaviour
{
    public void OnMouseDown() {
        SceneManager.LoadScene(11);
    }
}
