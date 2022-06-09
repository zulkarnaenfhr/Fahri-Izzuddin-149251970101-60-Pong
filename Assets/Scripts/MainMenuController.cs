using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Fahri I. Zulkarnaen - 149251970101-60");
    }

    public void PrintName()
    {
        Debug.Log("Created by Fahri Izzuddin Zulkarnaen");
    }
}
