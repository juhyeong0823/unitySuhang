using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadStage : MonoBehaviour
{
    public Image loadingBar;

    void Start()
    {
        StartCoroutine(StartGame());
    }
        
    IEnumerator StartGame()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync("Stage1");
        op.allowSceneActivation = false;

        float timer = 0.0f;
        while (!op.isDone)
        {
            timer += Time.deltaTime;
            if (op.progress < 0.9f)
            {
                loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount, op.progress, timer);
                if (loadingBar.fillAmount >= op.progress) { timer = 0f; }
            }
            else
            {
                StartCoroutine(wait());
                loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount, 1f, timer);
                if (loadingBar.fillAmount == 1.0f) { op.allowSceneActivation = true; yield break; }

            }
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
    }
}
