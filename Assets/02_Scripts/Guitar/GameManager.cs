
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

    [Header("Ŭ����")]
    public GameObject cvsClear;
    public Text playTimeText;

    public float playtime;//�÷��� �ð� �����ֱ�  
    public string rank; // ���
=======

    //cvsClear�� ���� �͵��ε� ���� �̰Ÿ� �������ָ� ��
    //�÷��� �ð� �����ֱ�  
    //�̵��Ÿ�
    //�Ҹ��� źâ ��
    //�̵��� �� �¼�
    //���� hp
>>>>>>> parent of bb77aac (하 제길 되는일이 하나도 없어..)

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
