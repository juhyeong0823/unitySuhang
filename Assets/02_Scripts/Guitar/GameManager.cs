
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


    //cvsClear�� ���� �͵��ε� ���� �̰Ÿ� �������ָ� ��
    //�÷��� �ð� �����ֱ�  
    //�̵��Ÿ�
    //�Ҹ��� źâ ��
    //�̵��� �� �¼�
    //���� hp

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
