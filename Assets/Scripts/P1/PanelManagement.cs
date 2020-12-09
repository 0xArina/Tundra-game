using UnityEngine;

public class PanelManagement : MonoBehaviour
{
    /*********** PUZZLE  ***********/
    public GameObject puzzleBG;
    public GameObject noSnowPzl;
    public GameObject towerCollider;
    public GameObject colliderNOSNOW;
    public GameObject litTowerPanel;

    /********* FOR ARROWS  *********/
    public GameObject bgRight;
    public GameObject bgLeft;

    /*********** SHELF ***********/
    public GameObject shelf;

    /*********** HINTS  ***********/
    public GameObject questionPanel;

    /*********** BOOK  ***********/
    public GameObject bookP1;

    // Start is called before the first frame update
    void Start()
    {
        // scene starts with bg under these 3
        puzzleBG.SetActive(false);
        noSnowPzl.SetActive(false);
        bgRight.SetActive(false);

        // shelf (inventory)
        shelf.SetActive(true);

        // memory book Page 1
        bookP1.SetActive(false);

        // ? / instuctions / hints
        questionPanel.SetActive(false);

        // lit Tower panel
        litTowerPanel.SetActive(false);

        //hide no snow tower collider
        colliderNOSNOW.SetActive(false);

    }


    /************  ARROWS MANAGEMENT  *************/

    // panel with broom
    public void ShowNewBG()
    {
        bgRight.SetActive(true);
        bgLeft.SetActive(false);
        towerCollider.SetActive(false);
        colliderNOSNOW.SetActive(false);
    }

    // panel with tower
    public void ShowFirstBG()
    {
        bgLeft.SetActive(true);
        bgRight.SetActive(false);
        towerCollider.SetActive(true);
    }


    /************  TOWER PUZZLE  *************/

    // Exit Tower Puzzle with snow
    public void exitPuzzle()
    {
        puzzleBG.SetActive(false);
        shelf.SetActive(true);
        towerCollider.SetActive(true);
    }

    // Exit Tower Puzzle without snow
    public void exitNoSnowPuzzle()
    {
        noSnowPzl.SetActive(false);
        shelf.SetActive(true);
        towerCollider.SetActive(false);

        //show no snow tower collider
        colliderNOSNOW.SetActive(true);

    }

    // back when puzzle is completed 
    public void backToLit()
    {
        noSnowPzl.SetActive(false);
        litTowerPanel.SetActive(true);
        // hide tower collider
        towerCollider.SetActive(false);
        colliderNOSNOW.SetActive(false);
    }

    /************  BOOK  *************/

    // open book page 1
    public void openBookP1()
    {
        bookP1.SetActive(true);

        towerCollider.SetActive(false);
        colliderNOSNOW.SetActive(false);

    }

    // close book page 1
    public void closeBookP1()
    {
        bookP1.SetActive(false);

        if (!bgLeft.activeInHierarchy)
        {
            towerCollider.SetActive(false);
            colliderNOSNOW.SetActive(false);
        }
        else if (bgLeft.activeInHierarchy)
        {
            towerCollider.SetActive(true);
            colliderNOSNOW.SetActive(true);
        }

        
    }


    /************  HINTS  *************/

    // open hints
    public void OpenQuestion()
    {
        questionPanel.SetActive(true);
        // hide tower collider
        towerCollider.SetActive(false);
        colliderNOSNOW.SetActive(false);
    }

    // close hints
    public void CloseQuestion()
    {
        questionPanel.SetActive(false);
        // show tower collider
        towerCollider.SetActive(true);
        colliderNOSNOW.SetActive(true);
    }

}
