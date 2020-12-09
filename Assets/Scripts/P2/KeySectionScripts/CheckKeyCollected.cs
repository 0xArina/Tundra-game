using UnityEngine;
using UnityEngine.UI;

public class CheckKeyCollected : MonoBehaviour
{

    public GameObject key;
    public static bool keyActive;

    public GameObject vialBlue;
    public GameObject vialGreen;
    public GameObject vialOrange;
    public GameObject vialPurple;
    public GameObject vialRed;
    public GameObject vialYellow;

    public Image background;
    public Sprite newBackground;
    public Sprite oldBackground;

    public static bool vialsCollected;

    public GameObject doorPrompt;
    public GameObject openDoorCollider;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(keyActive == true)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
        }

        if(vialsCollected == true)
        {
            vialBlue.SetActive(true);
            vialGreen.SetActive(true);
            vialOrange.SetActive(true);
            vialPurple.SetActive(true);
            vialRed.SetActive(true);
            vialYellow.SetActive(true);

        }
        else
        {
            vialBlue.SetActive(false);
            vialGreen.SetActive(false);
            vialOrange.SetActive(false);
            vialPurple.SetActive(false);
            vialRed.SetActive(false);
            vialYellow.SetActive(false);

        }
    }
}
