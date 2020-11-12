using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManagement : MonoBehaviour
{

    public GameObject puzzleBG;
    public GameObject noSnowPzl;

    // Start is called before the first frame update
    void Start()
    {
        puzzleBG.SetActive(false);
        noSnowPzl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPuzzle()
    {
        puzzleBG.SetActive(true);
        noSnowPzl.SetActive(false);
    }

    public void exitPuzzle()
    {
        puzzleBG.SetActive(false);
    }

    public void exitNoSnowPuzzle()
    {
        noSnowPzl.SetActive(false);
    }
}
