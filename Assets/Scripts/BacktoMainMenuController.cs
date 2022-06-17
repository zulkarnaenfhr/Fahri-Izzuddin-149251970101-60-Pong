using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainMenuController : MonoBehaviour
{
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
