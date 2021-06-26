using UnityEngine;
using UnityEngine.UI;
public class BtnEsc : MonoBehaviour
{
    public Button escBtn;

    void Start()
    {
        escBtn.onClick.AddListener(ExitGame);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // ���ø����̼� ����
#endif
    }


}
