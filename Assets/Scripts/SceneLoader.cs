using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
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

    public void Options()
    {
        // OPTIONS
        SceneManager.LoadScene(4);
    }


    public void LoadP1()
    {
        // P1 ENVIRONMENT
        SceneManager.LoadScene(5);
    }

    public void LoadP2()
    {
        // P2 ENVIRONMENT
        SceneManager.LoadScene(6);
    }

    public void LoadP2_LoadPuzzle()
    {
        SceneManager.LoadScene(7);
    }
   
    public void LoadP1_puzzle()
    {
    
        SceneManager.LoadScene(8);
    }
    

    public void LoadP2Scene_1_5()
    {

        SceneManager.LoadScene(10);
    }

    // EXIT GAME
    public void exitGame()
    {
        Application.Quit();
    }
}
