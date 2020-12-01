using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MusicDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public void KillSound()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
		if (objs.Length > 0)
			Destroy(this.gameObject);
    }
}
