using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playRockSound : MonoBehaviour
{
	public AudioSource rockS;
	public AudioClip[] rockClipArray;
	
	void Awake()
	{
		rockS = GetComponent<AudioSource> ();
	}
	
    public void Rocky()
    {
        rockS.clip = rockClipArray[Random.Range(0, rockClipArray.Length)];
		rockS.PlayOneShot (rockS.clip);
    }
}
