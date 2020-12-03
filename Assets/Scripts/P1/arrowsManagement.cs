using UnityEngine;

public class arrowsManagement : MonoBehaviour
{

    public GameObject bgRight;
    public GameObject bgLeft;
    // to hide the colliders so they wont be accesible in another bg
    public GameObject collider1;

    // Start is called before the first frame update
    void Start()
    {
        bgRight.SetActive(false);
    }

    public void OnMouseEnter()
    {
      
    }

    // panel with broom
    public void ShowNewBG()
    {
        bgRight.SetActive(true);
        collider1.SetActive(false);

    }

    // panel with tower
    public void ShowFirstBG()
    {
        bgLeft.SetActive(true);
        bgRight.SetActive(false);
        collider1.SetActive(true);
    }
}
