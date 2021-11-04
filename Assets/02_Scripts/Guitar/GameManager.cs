
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private static GameManager Instance = null;
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
    public static GameManager instance
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

<<<<<<< HEAD
    #region
    public WaitForSeconds sec1 = new WaitForSeconds(1f);
    public WaitForSeconds sec2 = new WaitForSeconds(2f);
    public WaitForSeconds sec5 = new WaitForSeconds(5f);
    
    public WaitForSeconds sec01 = new WaitForSeconds(0.1f);
    public WaitForSeconds sec02 = new WaitForSeconds(0.2f);
    public WaitForSeconds sec03 = new WaitForSeconds(0.3f);
    public WaitForSeconds sec04 = new WaitForSeconds(0.4f);
    public WaitForSeconds sec05 = new WaitForSeconds(0.5f);
    #endregion

    public AudioSource audioSource;
    public GameObject explosionEffect;
    public GameObject explosionEffectBigger;

    [Header("Å¬¸®¾î")]
    public GameObject cvsClear;
    public Text playTimeText;

    public float playtime;//ÇÃ·¹ÀÌ ½Ã°£ º¸¿©ÁÖ±â  
    public string rank; // µî±Ş
=======

    //cvsClear¿¡ ³ÖÀ» °ÍµéÀÎµ¥ ÀÌÁ¦ ÀÌ°Å¸¦ Àü´ŞÇØÁÖ¸é µÊ
    //ÇÃ·¹ÀÌ ½Ã°£ º¸¿©ÁÖ±â  
    //ÀÌµ¿°Å¸®
    //¼Ò¸ğÇÑ ÅºÃ¢ ¼ö
    //ÀÌµ¿ÇÑ ¹æ °Â¼ö
    //³²Àº hp
>>>>>>> parent of bb77aac (í•˜ ì œê¸¸ ë˜ëŠ”ì¼ì´ í•˜ë‚˜ë„ ì—†ì–´..)

    public GameObject cvsMenu;


    void Update()
    {
        playtime += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            cvsMenu.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }
    }
}
