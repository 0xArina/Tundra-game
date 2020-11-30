using UnityEngine;
using UnityEngine.UI;

public class fifthCode : MonoBehaviour
{
    private Image fifth;

    private int counter = 0;

    public Sprite f;
    public Sprite y;
    public Sprite b;
    public Sprite m;
    public Sprite p;

    void Start()
    {
        fifth = GameObject.Find("fifthCode").GetComponent<Image>();

    }

    public void OnMouseDown()
    {
        if (counter == 0)
        {
            fifth.sprite = p;
            counter++;
        }
        else if (counter == 1)
        {
            fifth.sprite = f;
            counter++;
        }
        else if (counter == 2)
        {
            fifth.sprite = m;
            counter++;
        }
        else if (counter == 3)
        {
            fifth.sprite = b;
            counter++;
        }
        else if (counter == 4)
        {
            fifth.sprite = y;
            counter = 0;
        }

    }
}
