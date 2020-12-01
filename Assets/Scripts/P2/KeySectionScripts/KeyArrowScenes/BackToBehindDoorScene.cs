using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToBehindDoorScene : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(14);
    }
}