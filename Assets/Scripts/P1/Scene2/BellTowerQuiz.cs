using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellTowerQuiz : MonoBehaviour
{
    /************* PUZZLE BG ***************/
    public GameObject puzzleBG;

    /************* GAME END PORTAL!!! AYE!!! ***************/
    public GameObject EndPortal;

    /************* TRIANGLES ON PUZZLE ***************/
    public GameObject redTriang;
    public GameObject greenTriang;
    public GameObject orangeTriang;
    public GameObject blueTriang;

    /************* TRIANGLES ON PANELS ***************/
    public GameObject redTriangPanel;
    public GameObject greenTriangPanel;
    public GameObject orangeTriangPanel;
    public GameObject blueTriangPanel;

    /************* STONES ON SLOT 1 ***************/
    public GameObject slot1_stone1;
    public GameObject slot1_stone2;
    public GameObject slot1_stone3;
    public GameObject slot1_stone4;

    /************* STONES ON SLOT 2 ***************/
    public GameObject slot2_stone1;
    public GameObject slot2_stone2;
    public GameObject slot2_stone3;
    public GameObject slot2_stone4;

    /************* STONES ON SLOT 3 ***************/
    public GameObject slot3_stone1;
    public GameObject slot3_stone2;
    public GameObject slot3_stone3;
    public GameObject slot3_stone4;

    /************* STONES ON SLOT 4 ***************/
    public GameObject slot4_stone1;
    public GameObject slot4_stone2;
    public GameObject slot4_stone3;
    public GameObject slot4_stone4;

    /************* STONES ON SHELF ***************/
    public GameObject stone1Shelf;
    public GameObject stone2Shelf;
    public GameObject stone3Shelf;
    public GameObject stone4Shelf;

    /************* BOOLS FOR CORRECT ORDER ***************/
    bool slot1_correct = false;
    bool slot2_correct = false;
    bool slot3_correct = false;
    bool slot4_correct = false;

    // Start is called before the first frame update
    void Start()
    {
        /************* GAME END PORTAL!!! AYE!!! ***************/
        EndPortal.SetActive(false);

        /************* HIDE TRIANGLES ***************/
        //redTriang.SetActive(false);
        //greenTriang.SetActive(false);
        //orangeTriang.SetActive(false);
        //blueTriang.SetActive(false);

        /************* HIDE TRIANGLES ON COLOR PLANES ***************/
        redTriangPanel.SetActive(false);
        greenTriangPanel.SetActive(false);
        orangeTriangPanel.SetActive(false);
        blueTriangPanel.SetActive(false);

        /************* HIDE STONES IN SLOTS ***************/
        /************* SLOT 1 ***************/
        slot1_stone1.SetActive(false);
        slot1_stone2.SetActive(false);
        slot1_stone3.SetActive(false);
        slot1_stone4.SetActive(false);

        /************* SLOT 2 ***************/
        slot2_stone1.SetActive(false);
        slot2_stone2.SetActive(false);
        slot2_stone3.SetActive(false);
        slot2_stone4.SetActive(false);

        /************* SLOT 3 ***************/
        slot3_stone1.SetActive(false);
        slot3_stone2.SetActive(false);
        slot3_stone3.SetActive(false);
        slot3_stone4.SetActive(false);

        /************* SLOT 4 ***************/
        slot4_stone1.SetActive(false);
        slot4_stone2.SetActive(false);
        slot4_stone3.SetActive(false);
        slot4_stone4.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stone1ToPuzzle()
    {
        if (puzzleBG.activeInHierarchy)
        {
            //check slot 1
            if (!slot1_stone1.activeInHierarchy && !slot1_stone2.activeInHierarchy && !slot1_stone3.activeInHierarchy && !slot1_stone4.activeInHierarchy)
            {
                // activate stone 1 in slot 1
                slot1_stone1.SetActive(true);
                //hide stone 1 on shelf
                stone1Shelf.SetActive(false);

                // correct bool + lit triangles
                slot1_correct = true;
                orangeTriang.SetActive(true);
                orangeTriangPanel.SetActive(true);

            }

            //check slot 2
            else if (!slot2_stone1.activeInHierarchy && !slot2_stone2.activeInHierarchy && !slot2_stone3.activeInHierarchy && !slot2_stone4.activeInHierarchy)
            {
                // activate stone 1 in slot 2
                slot2_stone1.SetActive(true);
                //hide stone 1 on shelf
                stone1Shelf.SetActive(false);
            }

            //check slot 3
            else if (!slot3_stone1.activeInHierarchy && !slot3_stone2.activeInHierarchy && !slot3_stone3.activeInHierarchy && !slot3_stone4.activeInHierarchy)
            {

                // activate stone 1 in slot 3
                slot3_stone1.SetActive(true);
                //hide stone 1 on shelf
                stone1Shelf.SetActive(false);
            }
            // check slot 4
            else if (!slot4_stone1.activeInHierarchy && !slot4_stone2.activeInHierarchy && !slot4_stone3.activeInHierarchy && !slot4_stone4.activeInHierarchy)
            {


                // activate stone 1 in slot 4
                slot4_stone1.SetActive(true);

                //hide stone 1 on shelf
                stone1Shelf.SetActive(false);

                checkOrder();
            }
        }


    }

    public void stone2ToPuzzle()
    {
        if (puzzleBG.activeInHierarchy)
        {
            //check slot 1
            if (!slot1_stone1.activeInHierarchy && !slot1_stone2.activeInHierarchy && !slot1_stone3.activeInHierarchy && !slot1_stone4.activeInHierarchy)
            {
                // activate stone 2 in slot 1
                slot1_stone2.SetActive(true);
                //hide stone 2 on shelf
                stone2Shelf.SetActive(false);
            }

            //check slot 2
            else if (!slot2_stone1.activeInHierarchy && !slot2_stone2.activeInHierarchy && !slot2_stone3.activeInHierarchy && !slot2_stone4.activeInHierarchy)
            {
                // activate stone 2 in slot 2
                slot2_stone2.SetActive(true);
                //hide stone 2 on shelf
                stone2Shelf.SetActive(false);

                // correct bool + lit triangles
                slot2_correct = true;
                redTriang.SetActive(true);
                redTriangPanel.SetActive(true);
            }

            //check slot 3
            else if (!slot3_stone1.activeInHierarchy && !slot3_stone2.activeInHierarchy && !slot3_stone3.activeInHierarchy && !slot3_stone4.activeInHierarchy)
            {

                // activate stone 2 in slot 3
                slot3_stone2.SetActive(true);
                //hide stone 2 on shelf
                stone2Shelf.SetActive(false);
            }
            // check slot 4
            else if (!slot4_stone1.activeInHierarchy && !slot4_stone2.activeInHierarchy && !slot4_stone3.activeInHierarchy && !slot4_stone4.activeInHierarchy)
            {


                // activate stone 2 in slot 4
                slot4_stone2.SetActive(true);

                //hide stone 2 on shelf
                stone2Shelf.SetActive(false);

                checkOrder();
            }
        }
    }

    public void stone3ToPuzzle()
    {
        if (puzzleBG.activeInHierarchy)
        {
            //check slot 1
            if (!slot1_stone1.activeInHierarchy && !slot1_stone2.activeInHierarchy && !slot1_stone3.activeInHierarchy && !slot1_stone4.activeInHierarchy)
            {
                // activate stone 3 in slot 1
                slot1_stone3.SetActive(true);
                //hide stone 3 on shelf
                stone3Shelf.SetActive(false);
            }

            //check slot 2
            else if (!slot2_stone1.activeInHierarchy && !slot2_stone2.activeInHierarchy && !slot2_stone3.activeInHierarchy && !slot2_stone4.activeInHierarchy)
            {
                // activate stone 3 in slot 2
                slot2_stone3.SetActive(true);
                //hide stone 3 on shelf
                stone3Shelf.SetActive(false);
            }

            //check slot 3
            else if (!slot3_stone1.activeInHierarchy && !slot3_stone2.activeInHierarchy && !slot3_stone3.activeInHierarchy && !slot3_stone4.activeInHierarchy)
            {

                // activate stone 3 in slot 3
                slot3_stone3.SetActive(true);
                //hide stone 3 on shelf
                stone3Shelf.SetActive(false);

                // correct bool + lit triangles
                slot3_correct = true;
                blueTriang.SetActive(true);
                blueTriangPanel.SetActive(true);
            }
            // check slot 4
            else if (!slot4_stone1.activeInHierarchy && !slot4_stone2.activeInHierarchy && !slot4_stone3.activeInHierarchy && !slot4_stone4.activeInHierarchy)
            {


                // activate stone 3 in slot 4
                slot4_stone3.SetActive(true);

                //hide stone 1 on shelf
                stone3Shelf.SetActive(false);

                checkOrder();
            }
        }
    }

    public void stone4ToPuzzle()
    {
        if (puzzleBG.activeInHierarchy)
        {
            //check slot 1
            if (!slot1_stone1.activeInHierarchy && !slot1_stone2.activeInHierarchy && !slot1_stone3.activeInHierarchy && !slot1_stone4.activeInHierarchy)
            {
                // activate stone 4 in slot 1
                slot1_stone4.SetActive(true);
                //hide stone 4 on shelf
                stone4Shelf.SetActive(false);
            }

            //check slot 2
            else if (!slot2_stone1.activeInHierarchy && !slot2_stone2.activeInHierarchy && !slot2_stone3.activeInHierarchy && !slot2_stone4.activeInHierarchy)
            {
                // activate stone 4 in slot 2
                slot2_stone4.SetActive(true);
                //hide stone 4 on shelf
                stone4Shelf.SetActive(false);
            }

            //check slot 3
            else if (!slot3_stone1.activeInHierarchy && !slot3_stone2.activeInHierarchy && !slot3_stone3.activeInHierarchy && !slot3_stone4.activeInHierarchy)
            {

                // activate stone 4 in slot 3
                slot3_stone4.SetActive(true);
                //hide stone 4 on shelf
                stone4Shelf.SetActive(false);
            }
            // check slot 4
            else if (!slot4_stone1.activeInHierarchy && !slot4_stone2.activeInHierarchy && !slot4_stone3.activeInHierarchy && !slot4_stone4.activeInHierarchy)
            {


                // activate stone 4 in slot 4
                slot4_stone4.SetActive(true);

                //hide stone 4 on shelf
                stone4Shelf.SetActive(false);

                // correct bool + lit triangles
                slot4_correct = true;
                greenTriang.SetActive(true);
                greenTriangPanel.SetActive(true);

                checkOrder();
            }
        }
    }

    void checkOrder()
    {
        if (slot1_correct && slot2_correct && slot3_correct && slot4_correct)
        {
            /************* GAME END PORTAL!!! AYE!!! ***************/
            EndPortal.SetActive(true);
        }
        else
        {
            // hide all stones
            /************* SLOT 1 ***************/
            slot1_stone1.SetActive(false);
            slot1_stone2.SetActive(false);
            slot1_stone3.SetActive(false);
            slot1_stone4.SetActive(false);

            /************* SLOT 2 ***************/
            slot2_stone1.SetActive(false);
            slot2_stone2.SetActive(false);
            slot2_stone3.SetActive(false);
            slot2_stone4.SetActive(false);

            /************* SLOT 3 ***************/
            slot3_stone1.SetActive(false);
            slot3_stone2.SetActive(false);
            slot3_stone3.SetActive(false);
            slot3_stone4.SetActive(false);

            /************* SLOT 4 ***************/
            slot4_stone1.SetActive(false);
            slot4_stone2.SetActive(false);
            slot4_stone3.SetActive(false);
            slot4_stone4.SetActive(false);

            //hide all triangles
            /************* HIDE TRIANGLES ***************/
            //redTriang.SetActive(false);
            //greenTriang.SetActive(false);
            //orangeTriang.SetActive(false);
            //blueTriang.SetActive(false);

            /************* HIDE TRIANGLES ON COLOR PLANES ***************/
            redTriangPanel.SetActive(false);
            greenTriangPanel.SetActive(false);
            orangeTriangPanel.SetActive(false);
            blueTriangPanel.SetActive(false);

            // show stones on shelf
            stone1Shelf.SetActive(true);
            stone2Shelf.SetActive(true);
            stone3Shelf.SetActive(true);
            stone4Shelf.SetActive(true);
        }
    }
}
