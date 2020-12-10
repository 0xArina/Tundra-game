using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOnShelf : MonoBehaviour
{
    /*********** COLLECTABLES  ON SHELF ***********/
    public GameObject spearOnShelf;
    public GameObject birdOnShelf;
    public GameObject dishOnShelf;
    public GameObject tridentOnShelf;

    /*********** COLLECTABLES IN SCENE ***********/
    public GameObject spear;
    public GameObject bird;
    public GameObject dish;
    public GameObject trident;

    /*********** STONES  ON SHELF ***********/
    public GameObject st1OnShelf;
    public GameObject st2OnShelf;
    public GameObject st3OnShelf;
    public GameObject st4OnShelf;

    /*********** STONES  ***********/
    public GameObject st1;
    public GameObject st2;
    public GameObject st3;
    public GameObject st4;

    // Start is called before the first frame update
    void Start()
    {
        /*********** HIDE OLLECTABLES ON SHELF ***********/
        spearOnShelf.SetActive(false);
        birdOnShelf.SetActive(false);
        dishOnShelf.SetActive(false);
        tridentOnShelf.SetActive(false);

        /*********** HIDE STONES ON SHELF  ***********/
        st2OnShelf.SetActive(false);
        st3OnShelf.SetActive(false);
        st4OnShelf.SetActive(false);
        st1OnShelf.SetActive(false);

        /*********** HIDE STONES ***********/
        st2.SetActive(false);
        st3.SetActive(false);
        st4.SetActive(false);
        st1.SetActive(false);

    }


    /*********** SHOW COLLECTABLES ON SHELF ***********/
    public void showSpearOnShelf()
    {
        spearOnShelf.SetActive(true);
        // hide it in scene
        spear.SetActive(false);
    }

    public void showBirdOnShelf()
    {
        birdOnShelf.SetActive(true);
        // hide it in scene
        bird.SetActive(false);
    }

    public void showDishOnShelf()
    {
        dishOnShelf.SetActive(true);
        // hide it in scene
        dish.SetActive(false);
    }

    public void showTridentOnShelf()
    {
        tridentOnShelf.SetActive(true);
        // hide it in scene
        trident.SetActive(false);
    }


    /*********** SHOW STONES  ON SHELF***********/
    public void showSt1OnShelf()
    {
        st1OnShelf.SetActive(true);
        st1.SetActive(false);
    }

    public void showSt2OnShelf()
    {
        st2OnShelf.SetActive(true);
        st2.SetActive(false);
    }

    public void showSt3OnShelf()
    {
        st3OnShelf.SetActive(true);
        st3.SetActive(false);
    }

    public void showSt4OnShelf()
    {
        st4OnShelf.SetActive(true);
        st4.SetActive(false);
    }

    /*********** SHOW STONES IN SCENE ***********/
    public void showSt1()
    {
        st1.SetActive(true);
    }

    public void showSt2()
    {
        st2.SetActive(true);
    }

    public void showSt3()
    {
        st3.SetActive(true);
    }

    public void showSt4()
    {
        st4.SetActive(true);
    }
}
