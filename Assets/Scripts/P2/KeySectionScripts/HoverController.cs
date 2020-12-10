using UnityEngine;
using UnityEngine.SceneManagement;

public class HoverController : MonoBehaviour
{
    public GameObject image;

    public void Start()
    {
        image.SetActive(false);
    }

    public void OnMouseEnter()
    {
        image.SetActive(true);
    }

    public void OnMouseDown()
    {
        // Load finished rune puzzle scene
        SceneManager.LoadScene(12);
    }

    public void OnMouseExit()
    {
        image.SetActive(false);
    }
}
