using UnityEngine;
using UnityEngine.UI;

public class firstCode : MonoBehaviour
{
    private Image first;

    private int counter = 1;

    public Sprite f;
    public Sprite y;
    public Sprite b;
    public Sprite m;
    public Sprite p;

    void Start()
    {
        first = GameObject.Find("firstCode").GetComponent<Image>();

    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            first.sprite = p;
            counter++;
        }
        else if (counter == 1)
        {
            first.sprite = f;
            counter++;
        }
        else if (counter == 2)
        {
            first.sprite = m;
            counter++;
        }
        else if (counter == 3)
        {
            first.sprite = b;
            counter++;
        }
        else if (counter == 4)
        {
            first.sprite = y;
            counter = 0;
        }

    }
}
