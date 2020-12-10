using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManage : MonoBehaviour
{
    public GameObject bellCollider;
    public GameObject BellBG;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (BellBG.activeInHierarchy)
        {
            bellCollider.SetActive(true);
        }
        else
        {
            bellCollider.SetActive(false);
        }
        
    }
}
