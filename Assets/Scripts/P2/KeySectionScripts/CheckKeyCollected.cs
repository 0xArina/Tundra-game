using UnityEngine;

public class CheckKeyCollected : MonoBehaviour
{

    public GameObject key;
    public static bool keyActive;



    public GameObject doorPrompt;
    public GameObject openDoorCollider;

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
    }
}
