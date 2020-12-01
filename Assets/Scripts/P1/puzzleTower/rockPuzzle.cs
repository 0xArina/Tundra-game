using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockPuzzle : MonoBehaviour
{
	private Image first;
    private Image second;
    private Image third;
    private Image fourth;
	private Image fifth;

    public Sprite fish;
    public Sprite moon;
    public Sprite bolt;
    public Sprite en;
	public Sprite tee;

    private bool unlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        first = GameObject.Find("fishSymbol").GetComponent<Image>();
        second = GameObject.Find("moonSymbol").GetComponent<Image>();
        third = GameObject.Find("boltSymbol").GetComponent<Image>();
        fourth = GameObject.Find("enSymbol").GetComponent<Image>();
		fifth = GameObject.Find("teeSymbol").GetComponent<Image>();

        //lockButton = GameObject.Find("lockButton").GetComponent<Image
    }

    // Update is called once per frame
    void Update()
    {
		//code below from numPuzzle
        //if(first.sprite == nine && second.sprite == four && third.sprite == two && fourth.sprite == zero)
        {
            Debug.Log("Clicked and unlocked");
            SceneManager.LoadScene(8);
        }
    }
}
