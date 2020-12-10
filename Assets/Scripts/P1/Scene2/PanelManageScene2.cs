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

    /*********** colliders ***************/
    public GameObject collider1;
    public GameObject collider2;
    public GameObject collider3;
    public GameObject collider4;
    public GameObject collider5;


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

    void Update()
    {
        if (bluePanel.activeInHierarchy || redPanel.activeInHierarchy || greenPanel.activeInHierarchy || orangePanel.activeInHierarchy)
        {
            // hide bell 
            BellBG.SetActive(false);
            //hide colliders 
            collider1.SetActive(false);
            collider2.SetActive(false);
            collider3.SetActive(false);
            collider4.SetActive(false);
            collider5.SetActive(false);
        }
    }

    /*********** ON ARROWS  ***********/
    public void onArrowLeft()
    {
        BellBG.SetActive(false);

        //hide colliders 
        collider1.SetActive(false);
        collider2.SetActive(false);
        collider3.SetActive(false);
        collider4.SetActive(false);
        collider5.SetActive(false);
    }

    public void onArrowRight()
    {
        BellBG.SetActive(true);
        CluePanel.SetActive(false);

        //show colliders 
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);
    }

    /*********** BOOK   ***********/
    public void openBook()
    {
        Book.SetActive(true);
        // hide shelf
        shelf.SetActive(false);

        // hide bell 
        BellBG.SetActive(false);
        // hide bell colliders
        collider1.SetActive(false);
        collider2.SetActive(false);
        collider3.SetActive(false);
        collider4.SetActive(false);
        collider5.SetActive(false);

    }

    public void closeBook()
    {
        Book.SetActive(false);
        // show shelf
        shelf.SetActive(true);


        if (!CluePanel.activeInHierarchy || !BellPuzzle.activeInHierarchy || !redPanel.activeInHierarchy || !bluePanel.activeInHierarchy || !greenPanel.activeInHierarchy || !orangePanel.activeInHierarchy)
        {
            //show bell
            BellBG.SetActive(true);
            //show colliders 
            collider1.SetActive(true);
            collider2.SetActive(true);
            collider3.SetActive(true);
            collider4.SetActive(true);
            collider5.SetActive(true);
        }
       

    }

    /*********** BELL PUZZLE   ***********/
    public void openBellPuzzle()
    {
        BellPuzzle.SetActive(true);
        // hide bell 
        BellBG.SetActive(false);
        //hide colliders 
        collider1.SetActive(false);
        collider2.SetActive(false);
        collider3.SetActive(false);
        collider4.SetActive(false);
        collider5.SetActive(false);

    }

    public void closeBellPuzzle()
    {
        //show bell
        BellBG.SetActive(true);

        BellPuzzle.SetActive(false);

        
        //show colliders 
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);
    }

    /*********** EXIT SPIKE PANELS   ***********/
    public void exitRedPanel()
    {
        redPanel.SetActive(false);

        //show bell
        BellBG.SetActive(true);
        //show colliders 
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);
    }

    public void exitGreenPanel()
    {
        greenPanel.SetActive(false);

        //show bell
        BellBG.SetActive(true);
        //show colliders 
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);
    }

    public void exitOrangePanel()
    {
        orangePanel.SetActive(false);

        //show bell
        BellBG.SetActive(true);
        //show colliders 
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);
    }

    public void exitBluePanel()
    {
        bluePanel.SetActive(false);

        //show bell
        BellBG.SetActive(true);
        //show colliders 
        collider1.SetActive(true);
        collider2.SetActive(true);
        collider3.SetActive(true);
        collider4.SetActive(true);
        collider5.SetActive(true);
    }
}
