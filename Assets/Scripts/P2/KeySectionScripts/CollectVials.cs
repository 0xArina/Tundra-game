using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectVials : MonoBehaviour
{
    private void OnMouseDown()
    {
        CheckKeyCollected.vialsCollected = true;
    }
}
