using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManageScene2 : MonoBehaviour
{
    /*********** ON ARROWS  ***********/
    public GameObject BellBG;
    public GameObject CluePanel;

    /*********** BELL PUZZLE   ***********/
    public GameObject BellPuzzle;

    /*********** BOOK   ***********/
    public GameObject Book;

    /*********** SHELF   ***********/
    public GameObject shelf;

    /*********** SPIKES PANELS   ***********/
    public GameObject orangePanel;
    public GameObject bluePanel;
    public GameObject greenPanel;
    public GameObject redPanel;


    // Start is called before the first frame update
    void Start()
    {
        //dont show book
        Book.SetActive(false);

        //dont show puzzle2
        BellPuzzle.SetActive(false);
        
        // dont show puzzle panels
        bluePanel.SetActive(false);
        orangePanel.SetActive(false);
        redPanel.SetActive(false);
        greenPanel.SetActive(false);

    }

    /*********** ON ARROWS  ***********/
    public void onArrowLeft()
    {
        BellBG.SetActive(false);
    }

    public void onArrowRight()
    {
        BellBG.SetActive(true);
    }

    /*********** BOOK   ***********/
    public void openBook()
    {
        Book.SetActive(true);
        // hide shelf
        shelf.SetActive(false);
        // hide bell colliders + scene
        BellBG.SetActive(false);

    }

    public void closeBook()
    {
        Book.SetActive(false);
        // show shelf
        shelf.SetActive(true);
       

    }

    /*********** BELL PUZZLE   ***********/
    public void openBellPuzzle()
    {
        BellPuzzle.SetActive(true);
        // hide bell colliders + scene
        BellBG.SetActive(false);

    }

    public void closeBellPuzzle()
    {
        BellPuzzle.SetActive(false);

    }

    /*********** EXIT SPIKE PANELS   ***********/
    public void exitRedPanel()
    {
        redPanel.SetActive(false);
    }

    public void exitGreenPanel()
    {
        greenPanel.SetActive(false);
    }

    public void exitOrangePanel()
    {
        orangePanel.SetActive(false);
    }

    public void exitBluePanel()
    {
        bluePanel.SetActive(false);
    }
}
