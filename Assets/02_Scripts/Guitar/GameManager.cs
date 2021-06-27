
using UnityEditor.SceneManagement;
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

    public WaitForSeconds sec1 = new WaitForSeconds(1f);
    public WaitForSeconds sec2 = new WaitForSeconds(2f);
    
    public WaitForSeconds sec01 = new WaitForSeconds(0.1f);
    public WaitForSeconds sec02 = new WaitForSeconds(0.2f);
    public WaitForSeconds sec03 = new WaitForSeconds(0.3f);
    public WaitForSeconds sec04 = new WaitForSeconds(0.4f);
    public WaitForSeconds sec05 = new WaitForSeconds(0.5f);


    public AudioSource audioSource;
    public GameObject explosionEffect;
    public GameObject explosionEffectBigger;

    [Header("클리어")]
    public int kill;    // 잡은 몹의 수
    public int playtime;//플레이 시간 보여주기  
    public float movedDistance;    //이동거리
    public string rank; // 등급

    public GameObject cvsMenu;
    public GameObject cvsClear;

    private bool isCvsMenuOn = false;



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!isCvsMenuOn)
            {
                cvsMenu.GetComponent<Canvas>().enabled = true;
                Time.timeScale = 0;
                    isCvsMenuOn = true;
                PlayerAttack.canFire2 = false;
            }
            else
            {
                cvsMenu.GetComponent<Canvas>().enabled = false;
                Time.timeScale = 1;
                isCvsMenuOn = false;
                PlayerAttack.canFire2 = true;

            }
        }
    }

    public void ExplosionPlay(Transform instantiatePos)
    {
        Instantiate(explosionEffect, instantiatePos.position, Quaternion.identity);
    }

    public void BiggerExplosionPlay(Transform instantiatePos)
    {
        Instantiate(explosionEffectBigger, instantiatePos.position, Quaternion.identity);
    }

    public void ShootSoundPlay(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void SetMusicVolume(float volumevalue)
    {
        audioSource.volume = volumevalue;
    }
}
