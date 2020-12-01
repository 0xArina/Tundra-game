using UnityEngine;
using UnityEngine.UI;

public class firstNumber : MonoBehaviour
{
    private Image first;

    private int counter = 0;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;

    void Start()
    {
        first = GameObject.Find("firstNum").GetComponent<Image>();
    }

    public void OnMouseDown()
    {
        if(counter == 0)
        {
            first.sprite = one;
            counter++;
        }else if(counter == 1)
        {
            first.sprite = two;
            counter++;
        }else if(counter == 2)
        {
            first.sprite = three;
            counter++;
        }else if(counter == 3)
        {
            first.sprite = four;
            counter++;
        }else if(counter == 4)
        {
            first.sprite = five;
            counter++;
        }else if(counter == 5)
        {
            first.sprite = six;
            counter++;
        }else if(counter == 6)
        {
            first.sprite = seven;
            counter++;
        }else if(counter == 7)
        {
            first.sprite = eight;
            counter++;
        }
        else if(counter == 8)
        {
            first.sprite = nine;
            counter++;
        }else if(counter == 9)
        {
            first.sprite = zero;
            counter = 0;
        }
       
    }
}
