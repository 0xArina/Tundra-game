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
		foreach(GameObject track in objs)
			GameObject.Destroy(track);
    }
}
