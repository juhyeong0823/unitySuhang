using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    #region

    private static uiManager Instance = null;
    void Awake()
    {
        if (null == Instance)
        {
            Instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static uiManager instance
    {
        get
        {
            if (null == Instance)
            {
                return null;
            }
            return Instance;
        }
    }
    #endregion 
    // ΩÃ±€≈Ê

    public Image bossPattern = null;
    public Text eventMessage = null;
    private WaitForSeconds sec3 = new WaitForSeconds(3f);

    public void On(string message, Sprite spr)
    {
        bossPattern.gameObject.SetActive(true);
        eventMessage.gameObject.SetActive(true);
        if(message != null)
        {
            eventMessage.text = message;
        }
        if (spr != null)
        {
            bossPattern.sprite = spr;
        }
    }
    public void Off(string message, Sprite spr)
    {
        StartCoroutine(OffWait());       
    }
    IEnumerator OffWait()
    {
        yield return sec3;
        bossPattern.gameObject.SetActive(false);
        eventMessage.gameObject.SetActive(false);
        bossPattern.sprite = null;
        eventMessage.text = null;
    }



}
