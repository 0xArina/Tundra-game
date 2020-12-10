using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /***********************
     *         UI          *
     ***********************/

    public void MainMenu()
    {
        // MAIN MENU
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        // CHOOSE YOUR PLAYER
        SceneManager.LoadScene(1);
    }

    public void P1chosen()
    {
        // INSTRUCTIONS FOR P1
        SceneManager.LoadScene(2);
    }

    public void P2Chosen()
    {
        // INSTRUCTIONS FOR P2
        SceneManager.LoadScene(3);
    }

    public void StoryCommonP1()
    {
        // STORY FOR P1 PART 1
        SceneManager.LoadScene(22);
    }

    public void StoryP1()
    {
        // STORY FOR P1 PART 2
        SceneManager.LoadScene(20);
    }

    public void StoryCommonP2()
    {
        // STORY FOR P2 PART 1
        SceneManager.LoadScene(19);
    }

    public void StoryP2()
    {
        // STORY FOR P2
        SceneManager.LoadScene(21);
    }

    public void Options()
    {
        // OPTIONS
        SceneManager.LoadScene(4);
    }

    // EXIT GAME
    public void exitGame()
    {
        Application.Quit();
    }

    /***********************
     *         P1          *
     ***********************/

    public void LoadP1()
    {
        // P1 ENVIRONMENT
        SceneManager.LoadScene(5);
    }

    public void LoadP1_Puzzle2()
    {
        // P1 PUZZLE 2
        SceneManager.LoadScene(23);
    }

    /* ????????????????????????????????
     * 
     * scene 8 in Build Settings is P2_Scene03
     * 
    public void LoadP1_puzzle()   <----- but it says LoadP1 puzzle
    {
        // P1 PUZZLE
        SceneManager.LoadScene(8);
    }
    *
    *??????????????????????????????????
    */

    /***********************
     *         P2          *
     ***********************/

    public void LoadP2()
    {
        // P2 ENVIRONMENT
        SceneManager.LoadScene(6);
    }

    public void LoadP2_LoadPuzzle()
    {
        // P2 PUZZLE 
        SceneManager.LoadScene(7);
    }

    public void LoadP2Scene_ClueRoom()
    {

        SceneManager.LoadScene(9);
    }

    public void LoadP2Scene_1_5()
    {

        SceneManager.LoadScene(10);
    }

    //KEY ACTIVE SCENES FOR P2

    public void LoadP2_Scene1_KEY()
    {
        SceneManager.LoadScene(11);
    }
    public void LoadP2_CompletedRunePuzzle_KEY()
    {
        SceneManager.LoadScene(12);
    }

}
