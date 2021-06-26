using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadStartScene : MonoBehaviour
{
    public Button returnBtn;



    private void Start()
    {
        returnBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Start");
            this.gameObject.SetActive(false);
        });
    }

}
