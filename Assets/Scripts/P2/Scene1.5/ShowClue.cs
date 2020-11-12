using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowClue : MonoBehaviour
{

    public GameObject clue;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(10);
    }

}
