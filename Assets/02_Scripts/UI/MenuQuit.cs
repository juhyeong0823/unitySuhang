using UnityEngine;
using UnityEngine.UI;

public class MenuQuit : MonoBehaviour
{
    Button menuQuitBtn;

    [SerializeField]
    private GameObject cvsMenu;

    void Start()
    {
        menuQuitBtn = this.transform.GetComponent<Button>();
        menuQuitBtn.onClick.AddListener(MenuOff);
    }

    private void MenuOff()
    {
        cvsMenu.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
}
