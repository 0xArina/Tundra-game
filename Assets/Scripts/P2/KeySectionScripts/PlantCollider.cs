using UnityEngine;

public class PlantCollider : MonoBehaviour
{
    public GameObject image;

    // Start is called before the first frame update
    public void Start()
    {
        image.SetActive(false);
    }

    public void OnMouseEnter()
    {
        image.SetActive(true);
    }

    public void OnMouseExit()
    {
        image.SetActive(false);
    }

    public void OnMouseDown()
    {
        CheckKeyCollected.keyActive = true;
    }
}
