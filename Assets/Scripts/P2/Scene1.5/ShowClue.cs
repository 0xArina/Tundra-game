using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowClue : MonoBehaviour
{

    public GameObject clue;

    // Start is called before the first frame update
    void Start()
    {
        clue.SetActive(false);
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene(11);
    }

    public void OnMouseEnter()
    {
        clue.SetActive(true);
    }

    public void OnMouseExit()
    {
        clue.SetActive(false);
    }
}
