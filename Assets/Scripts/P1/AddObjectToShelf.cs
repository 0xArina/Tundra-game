using UnityEngine;

public class AddObjectToShelf : MonoBehaviour
{
    public GameObject broomOnShelf;
    public GameObject broomInScene;

    // Start is called before the first frame update
    void Start()
    {
        broomOnShelf.SetActive(false);
    }

    public void addToShelf()
    {
        broomInScene.SetActive(false);
        broomOnShelf.SetActive(true);
    }
}
