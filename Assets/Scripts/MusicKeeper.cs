using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MusicKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
		if (objs.Length > 1)
			Destroy(this.gameObject);
		
		DontDestroyOnLoad(this.gameObject);
    }
}
