using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addObjectsToColorPanels : MonoBehaviour
{
    /************* ON SHELF  ***************/
    public GameObject bird;
    public GameObject dish;
    public GameObject trident;
    public GameObject spear;

    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject stone4;

    /************* ON COLOR PANELS  ***************/
    public GameObject birdOnPanel;
    public GameObject dishOnPanel;
    public GameObject tridentOnPanel;
    public GameObject spearOnPanel;

    /************* PANELS ***************/

    public GameObject redPanel;
    public GameObject greenPanel;
    public GameObject orangePanel;
    public GameObject bluePanel;

    // Start is called before the first frame update
    void Start()
    {
        birdOnPanel.SetActive(false);
        dishOnPanel.SetActive(false);
        tridentOnPanel.SetActive(false);
        spearOnPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dishToRed()
    {
        if (redPanel.activeInHierarchy)
        {
            dish.SetActive(false);
            dishOnPanel.SetActive(true);
            stone2.SetActive(true);
        }
        
    }

    public void birdToOrange()
    {
        if (orangePanel.activeInHierarchy)
        {
            bird.SetActive(false);
            birdOnPanel.SetActive(true);
            stone1.SetActive(true);
        }
        
    }

    public void tridentToGreen()
    {
        if (greenPanel.activeInHierarchy)
        {
            trident.SetActive(false);
            tridentOnPanel.SetActive(true);
            stone4.SetActive(true);
        }
        
    }

    public void spearToBlue()
    {
        if (bluePanel.activeInHierarchy)
        {
            spear.SetActive(false);
            spearOnPanel.SetActive(true);
            stone3.SetActive(true);
        }
        
    }
}
