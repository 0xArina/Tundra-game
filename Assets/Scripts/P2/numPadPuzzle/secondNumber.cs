using UnityEngine;
using UnityEngine.UI;

public class secondNumber : MonoBehaviour
{
    private Image second;

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
        second = GameObject.Find("secondNum").GetComponent<Image>();
    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            second.sprite = one;
            counter++;
        }
        else if (counter == 1)
        {
            second.sprite = two;
            counter++;
        }
        else if (counter == 2)
        {
            second.sprite = three;
            counter++;
        }
        else if (counter == 3)
        {
            second.sprite = four;
            counter++;
        }
        else if (counter == 4)
        {
            second.sprite = five;
            counter++;
        }
        else if (counter == 5)
        {
            second.sprite = six;
            counter++;
        }
        else if (counter == 6)
        {
            second.sprite = seven;
            counter++;
        }
        else if (counter == 7)
        {
            second.sprite = eight;
            counter++;
        }
        else if (counter == 8)
        {
            second.sprite = nine;
            counter++;
        }
        else if (counter == 9)
        {
            second.sprite = zero;
            counter = 0;
        }

    }
}
