using UnityEngine;

public class PanelManagement : MonoBehaviour
{

    public GameObject puzzleBG;
    public GameObject noSnowPzl;
    public GameObject shelf;
    public GameObject questionPanel;
    public GameObject bookP1;
    public GameObject litTowerPanel;

    // Start is called before the first frame update
    void Start()
    {
        // scene starts with bg under these 2
        puzzleBG.SetActive(false);
        noSnowPzl.SetActive(false);

        // shelf (inventory)
        shelf.SetActive(true);

        // memory book Page 1
        bookP1.SetActive(false);

        // ? / instuctions / hints
        questionPanel.SetActive(false);

        // lit Tower panel
        litTowerPanel.SetActive(false);
    }

    public void exitPuzzle()
    {
        puzzleBG.SetActive(false);
        shelf.SetActive(true);
    }

    public void exitNoSnowPuzzle()
    {
        noSnowPzl.SetActive(false);
        shelf.SetActive(true);
    }

    // open book page 1
    public void openBookP1()
    {
        bookP1.SetActive(true);
    }

    // close book page 1
    public void closeBookP1()
    {
        bookP1.SetActive(false);
    }

    // open hints
    public void OpenQuestion()
    {
        questionPanel.SetActive(true);
    }

    // close hints
    public void CloseQuestion()
    {
        questionPanel.SetActive(false);
    }

    public void backToLit()
    {
        noSnowPzl.SetActive(false);
        litTowerPanel.SetActive(true);
    }
}
