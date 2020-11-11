using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObjectToShelf : MonoBehaviour
{
    public GameObject broomOnShelf;
    public GameObject broomInScene;
    // Start is called before the first frame update
    void Start()
    {
        broomOnShelf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToShelf()
    {
        broomInScene.SetActive(false);
        broomOnShelf.SetActive(true);
    }
}
