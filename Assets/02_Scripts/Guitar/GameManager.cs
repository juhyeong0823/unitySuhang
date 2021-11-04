
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

    [Header("클리어")]
    public GameObject cvsClear;
    public Text playTimeText;

    public float playtime;//플레이 시간 보여주기  
    public string rank; // 등급
=======

    //cvsClear에 넣을 것들인데 이제 이거를 전달해주면 됨
    //플레이 시간 보여주기  
    //이동거리
    //소모한 탄창 수
    //이동한 방 걔수
    //남은 hp
>>>>>>> parent of bb77aac (�븯 �젣湲� �릺�뒗�씪�씠 �븯�굹�룄 �뾾�뼱..)

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
