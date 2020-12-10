using UnityEngine;
using UnityEngine.EventSystems;

public class DropAndClean : MonoBehaviour, IDropHandler
{

    public GameObject puzzleNoSnow;
    public GameObject puzzleSnow;
    public GameObject shelf;
    public GameObject collider1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            // eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().position;
            puzzleNoSnow.SetActive(true);
            puzzleSnow.SetActive(false);
           
           collider1.SetActive(false);
            
            shelf.SetActive(false);
        }
    }
}
