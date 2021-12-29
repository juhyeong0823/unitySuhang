using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class GameStart : MonoBehaviour
{
    public Text startText;

    public Button cleakPanel;

    void Start()
    {
        startText.DOFade(0, 2).OnComplete(() =>
        {
            startText.DOFade(1, 2).OnComplete(() =>
            {
                return;
            });
        }).SetLoops(-1);

        cleakPanel.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Stage1");
        });
    }
}
