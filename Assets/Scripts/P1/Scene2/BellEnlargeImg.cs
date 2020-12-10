using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellEnlargeImg : MonoBehaviour
{
    public GameObject imageBell;
    public GameObject puzzleBG;
    public GameObject BellBG;
  

    public void Start()
    {
        //dont show enlarged image
        imageBell.SetActive(false);

    }

    public void OnMouseEnter()
    {

        imageBell.SetActive(true);

        Debug.Log("Ray hit bell");
    }

    public void OnMouseDown()
    {
        // OPEN PUZZLE WHEN BELL IS PRESSED

        puzzleBG.SetActive(true);

        BellBG.SetActive(false);


    }

    public void OnMouseExit()
    {

        imageBell.SetActive(false);
    }
}
