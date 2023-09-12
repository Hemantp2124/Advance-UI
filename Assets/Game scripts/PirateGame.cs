using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PirateGame : MonoBehaviour
{
    public static PirateGame instance;
    public GameObject loadingScreen;

    private void Awake()
    {
        instance = this;
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }

    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync((int)1);
        SceneManager.LoadSceneAsync((int)1,LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync((int)1,LoadSceneMode.Additive);

    }
}
 