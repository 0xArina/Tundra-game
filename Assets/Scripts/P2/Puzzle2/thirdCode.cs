using UnityEngine;
using UnityEngine.UI;

public class thirdCode : MonoBehaviour
{
    private Image third;

    private int counter = 3;

    public Sprite f;
    public Sprite y;
    public Sprite b;
    public Sprite m;
    public Sprite p;

    void Start()
    {
        third = GameObject.Find("thirdCode").GetComponent<Image>();

    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            third.sprite = p;
            counter++;
        }
        else if (counter == 1)
        {
            third.sprite = f;
            counter++;
        }
        else if (counter == 2)
        {
            third.sprite = m;
            counter++;
        }
        else if (counter == 3)
        {
            third.sprite = b;
            counter++;
        }
        else if (counter == 4)
        {
            third.sprite = y;
            counter = 0;
        }

    }
}
