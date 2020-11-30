using UnityEngine;

public class MouseHover : MonoBehaviour
{
	public Color textBrown = new Color(58,48,48);
	
    void Start(){
		var renderer = GetComponent<Renderer>();
		renderer.material.color = textBrown;
	}

	void OnMouseEnter(){
		var renderer = GetComponent<Renderer>();
		renderer.material.color = Color.white;
	}

	void OnMouseExit() {
		var renderer = GetComponent<Renderer>();
		renderer.material.color = textBrown;
	}
}
