using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManagement : MonoBehaviour
{

    public GameObject puzzleBG;
    public GameObject noSnowPzl;
    public GameObject shelf;

    // Start is called before the first frame update
    void Start()
    {
        // scene starts with bg under these 2
        puzzleBG.SetActive(false);
        noSnowPzl.SetActive(false);
        shelf.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void exitPuzzle()
    {
        puzzleBG.SetActive(false);
        //noSnowPzl.SetActive(false);
        shelf.SetActive(true);
    }

    public void exitNoSnowPuzzle()
    {
        noSnowPzl.SetActive(false);
        shelf.SetActive(true);
    }
}
