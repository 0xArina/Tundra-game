using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnlarge : MonoBehaviour
{
    public GameObject colourSpike;
    public GameObject puzzleBG;



    public void Start()
    {
        //dont show enlarged image
        colourSpike.SetActive(false);

    }

    public void OnMouseEnter()
    {

        colourSpike.SetActive(true);

        Debug.Log("Ray hit colourSpike");
    }

    public void OnMouseDown()
    {
        // OPEN PUZZLE WHEN BELL IS PRESSED

        puzzleBG.SetActive(true);



    }

    public void OnMouseExit()
    {

        colourSpike.SetActive(false);
    }
}
