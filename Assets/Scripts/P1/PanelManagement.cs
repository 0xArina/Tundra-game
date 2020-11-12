using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManagement : MonoBehaviour
{

    public GameObject puzzleBG;

    // Start is called before the first frame update
    void Start()
    {
        puzzleBG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPuzzle()
    {
        puzzleBG.SetActive(true);
    }

    public void exitPuzzle()
    {
        puzzleBG.SetActive(false);
    }
}
