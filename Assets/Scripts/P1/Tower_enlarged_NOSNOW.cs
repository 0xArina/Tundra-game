using UnityEngine;

public class Tower_enlarged_NOSNOW : MonoBehaviour
{
    public GameObject imageTower;
    public GameObject puzzleBG;
    public GameObject puzzleNoSnow;
   

    

    public void Start()
    {
        //dont show enlarged image
        imageTower.SetActive(false);
        
    }

    public void OnMouseEnter()
    {
        
        imageTower.SetActive(true);
        
        Debug.Log("Ray hit tower");
    }

    public void OnMouseDown()
    {
        // OPEN PUZZLE WITH NO SNOW WHEN TOWER IS PRESSED

        puzzleNoSnow.SetActive(true);
        puzzleBG.SetActive(false);

    }

    public void OnMouseExit()
    {
        imageTower.SetActive(false);
    }
}