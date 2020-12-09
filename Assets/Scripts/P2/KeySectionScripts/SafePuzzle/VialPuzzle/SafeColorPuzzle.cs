using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeColorPuzzle : MonoBehaviour
{

    private Image input1;
    private Image input2;
    private Image input3;
    private Image input4;

    public Sprite blue;
    public Sprite green;
    public Sprite orange;
    public Sprite purple;
    public Sprite red;
    public Sprite yellow;

    public Sprite symbolOne;
    public Sprite symbolTwo;
    public Sprite symbolThree;
    public Sprite symbolFour;

    public Sprite blank;

    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

        input1 = GameObject.Find("FirstInput").GetComponent<Image>();
        input2 = GameObject.Find("SecondInput").GetComponent<Image>();
        input3 = GameObject.Find("ThirdInput").GetComponent<Image>();
        input4 = GameObject.Find("FourthInput").GetComponent<Image>();

        input1.sprite = blank;
        input2.sprite = blank;
        input3.sprite = blank;
        input4.sprite = blank;
    }

    public void checkColorPosition(Sprite color)
    {
        if(counter == 1)
        {
            input1.sprite = color;
        }else if (counter == 2)
        {
            input2.sprite = color;
        }else if (counter == 3)
        {
            input3.sprite = color;
        }else if (counter == 4)
        {
            input4.sprite = color;
        }else if(counter > 4)
        {
            input1.sprite = blank;
            input2.sprite = blank;
            input3.sprite = blank;
            input4.sprite = blank;
            counter = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.back);
            Debug.Log("Click");

            if (hit.transform.name == "unlockButton")
            {
                Debug.Log("Clicked Unlock Btn");

                if (input1.sprite == purple && input2.sprite == green && input3.sprite == orange && input4.sprite == blue)
                {
                    input1.sprite = symbolOne;
                    input2.sprite = symbolTwo;
                    input3.sprite = symbolThree;
                    input4.sprite = symbolFour;
                }
                else
                {
                    input1.sprite = blank;
                    input2.sprite = blank;
                    input3.sprite = blank; 
                    input4.sprite = blank;
                    counter = 0;
                }
            }
            else if (hit.transform.name == "test-tub-blue")
            {
                counter++;
                checkColorPosition(blue);
            } 
            else if (hit.transform.name == "test-tub-green")
            {
                counter++;
                checkColorPosition(green);
            }
            else if (hit.transform.name == "test-tub-yellow")
            {
                counter++;
                checkColorPosition(yellow);
            }
            else if (hit.transform.name == "test-tub-orange")
            {
                counter++;
                checkColorPosition(orange);
            }
            else if (hit.transform.name == "test-tub-red")
            {
                counter++;
                checkColorPosition(red);
            } 
            else if (hit.transform.name == "test-tub-purple")
            {
                counter++;
                checkColorPosition(purple);
            }
        }
    }

}
