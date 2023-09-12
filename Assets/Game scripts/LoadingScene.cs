using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;
    // Start is called before the first frame update
    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }
    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progrssValue = Mathf.Clamp01(operation.progress / 0.9f);

            LoadingBarFill.fillAmount = progrssValue;
            yield return null;
        }
    }
   
}
