using UnityEngine;

public class Tower_enlarged : MonoBehaviour
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
        // OPEN PUZZLE WITH SNOW WHEN TOWER IS PRESSED
        
        puzzleBG.SetActive(true);
        
    }

    public void OnMouseExit()
    {
        imageTower.SetActive(false);
       
    }
}