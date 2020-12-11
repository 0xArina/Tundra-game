using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectVials : MonoBehaviour
{

    public GameObject vialsInScene;

    private void OnMouseDown()
    {
        CheckKeyCollected.vialsCollected = true;

        vialsInScene.SetActive(false);
    }
}
