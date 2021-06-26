
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


    //cvsClear에 넣을 것들인데 이제 이거를 전달해주면 됨
    //플레이 시간 보여주기  
    //이동거리
    //소모한 탄창 수
    //이동한 방 걔수
    //남은 hp

    public GameObject cvsMenu;
    public GameObject cvsClear;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            cvsMenu.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }
    }
}
