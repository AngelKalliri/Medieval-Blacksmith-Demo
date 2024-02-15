using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartDemo()
    {
        SceneManager.LoadScene("MainScene");
    }
}
