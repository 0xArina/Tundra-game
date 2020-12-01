using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToDoorScene : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(13);
    }
}
