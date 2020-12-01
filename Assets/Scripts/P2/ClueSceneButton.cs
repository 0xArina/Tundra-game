using UnityEngine;
using UnityEngine.SceneManagement;

public class ClueSceneButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(9);
    }
}
