using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeInputs : MonoBehaviour
{

    private Image input1;
    private Image input2;
    private Image input3;
    private Image input4;

    public int counter = 0;

    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;

    public Sprite blank;

    void Start()
    {
        input1 = GameObject.Find("FirstInput").GetComponent<Image>();
        input2 = GameObject.Find("SecondInput").GetComponent<Image>();
        input3 = GameObject.Find("ThirdInput").GetComponent<Image>();
        input4 = GameObject.Find("FourthInput").GetComponent<Image>();
    }

    void Update()
    {

        if (input1.sprite == seven && input2.sprite == four && input3.sprite == nine && input4.sprite == one)
        {
            //SceneManager.LoadScene()
        }
        if(counter == 0)
        {
            input1.sprite = blank;
            input2.sprite = blank;
            input3.sprite = blank;
            input4.sprite = blank;
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.back);


            if(hit.transform.name == "submit")
            {
                if (input1.sprite == seven && input2.sprite == four && input3.sprite == nine && input4.sprite == one)
                {
                    SceneManager.LoadScene(17);
                }
                else
                {
                    counter = 0;
                }
            }
            else if (hit.transform.name == "1") { 
                counter++;
                if(counter == 1)
                {
                    input1.sprite = one;  
                }else if(counter == 2)
                {
                    input2.sprite = one;
                }else if(counter == 3)
                {
                    input3.sprite = one;
                }else if(counter == 4)
                {
                    input4.sprite = one;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "2")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = two;
                }
                else if (counter == 2)
                {
                    input2.sprite = two;
                }
                else if (counter == 3)
                {
                    input3.sprite = two;
                }
                else if (counter == 4)
                {
                    input4.sprite = two;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "3")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = three;
                }
                else if (counter == 2)
                {
                    input2.sprite = three;
                }
                else if (counter == 3)
                {
                    input3.sprite = three;
                }
                else if (counter == 4)
                {
                    input4.sprite = three;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "4")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = four;
                }
                else if (counter == 2)
                {
                    input2.sprite = four;
                }
                else if (counter == 3)
                {
                    input3.sprite = four;
                }
                else if (counter == 4)
                {
                    input4.sprite = four;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "5")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = five;
                }
                else if (counter == 2)
                {
                    input2.sprite = five;
                }
                else if (counter == 3)
                {
                    input3.sprite = five;
                }
                else if (counter == 4)
                {
                    input4.sprite = five;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "6")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = six;
                }
                else if (counter == 2)
                {
                    input2.sprite = six;
                }
                else if (counter == 3)
                {
                    input3.sprite = six;
                }
                else if (counter == 4)
                {
                    input4.sprite = six;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "7")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = seven;
                }
                else if (counter == 2)
                {
                    input2.sprite = seven;
                }
                else if (counter == 3)
                {
                    input3.sprite = seven;
                }
                else if (counter == 4)
                {
                    input4.sprite = seven;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "8")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = eight;
                }
                else if (counter == 2)
                {
                    input2.sprite = eight;
                }
                else if (counter == 3)
                {
                    input3.sprite = eight;
                }
                else if (counter == 4)
                {
                    input4.sprite = eight;
                    //counter = 0;
                }
            }

            if (hit.transform.name == "9")
            {
                counter++;
                if (counter == 1)
                {
                    input1.sprite = nine;
                }
                else if (counter == 2)
                {
                    input2.sprite = nine;
                }
                else if (counter == 3)
                {
                    input3.sprite = nine;
                }
                else if (counter == 4)
                {
                    input4.sprite = nine;
                    //counter = 0;
                }
            }

        }
    }

}
