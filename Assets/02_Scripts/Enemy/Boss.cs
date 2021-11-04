using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Boss : MonoBehaviour
{

    public List<SideObj> sideObjs = new List<SideObj>(); // °¡ÀåÀÚ¸® 4°³ ºÎ½Ã¸é º¸½º ¶§¸± ¼ö ÀÖ°Ô

<<<<<<< HEAD
    public float curHp = 15;
    public float maxHp = 15;

    public Slider hpbar;

    public GameObject player;
    public static int damage = 5;
=======
    public int hp;
    public static int damage = 10;
>>>>>>> parent of bb77aac (í•˜ ì œê¸¸ ë˜ëŠ”ì¼ì´ í•˜ë‚˜ë„ ì—†ì–´..)
    public GameObject clearUI;
    public GameObject shield;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("PlayerBullet"))
        {
            if (sideObjs.Count > 0)
            {
                return;
            }
            else
            {
<<<<<<< HEAD
                if(shield != null)  Destroy(shield);

                hpbar.gameObject.SetActive(true);
                this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
                hpbar.value = (float)curHp / (float)maxHp;


                CancelInvoke("HpbarOff");
                Invoke("HpbarOff", 1f);

                if (curHp <= 0) GameOver();
=======
                if(shield != null)
                {
                    Destroy(shield);
                }
                hp -= Player.damage;
                if (hp <= 0)
                {
                    Hitted();
                    clearUI.transform.position = this.transform.position;
                    clearUI.SetActive(true);    
                    // ÀÌ°Å º¸½º Á×´Â ¾Ö´Ï¸ŞÀÌ¼Ç? ÀÌÆåÆ®? ³ª¿À°í ¸î ÃÊ µÚ¿¡ ÄÑ´Â°Å·Î °¡º¸ÀÚ
                    Destroy(this.gameObject);
                    //¿©±â¼­ °ÔÀÓ ³¡³ª¸é ¹¹ ¶ß°Ô ÇÏÀÚ
                }
>>>>>>> parent of bb77aac (í•˜ ì œê¸¸ ë˜ëŠ”ì¼ì´ í•˜ë‚˜ë„ ì—†ì–´..)
            }
            Destroy(col.gameObject);
        }
    }


    void HpbarOff()
    {
        hpbar.gameObject.SetActive(false);
    }

    public void RemoveTop(SideObj removeObj) // °Á ¸Ç Ã¹¹øÂ°°Å Áö¿ì´Â°Å
    {
        sideObjs.Remove(removeObj);
    }
<<<<<<< HEAD

    void GameOver()
    {
        player.SetActive(false);
        clearUI.transform.position = this.transform.position;
        clearUI.SetActive(true);
        Time.timeScale = 0;
        // ÀÌ°Å º¸½º Á×´Â ¾Ö´Ï¸ŞÀÌ¼Ç? ÀÌÆåÆ®? ³ª¿À°í ¸î ÃÊ µÚ¿¡ ÄÑ´Â°Å·Î °¡º¸ÀÚ
        Destroy(this.gameObject);
        GameManager.instance.BiggerExplosionPlay(this.transform);
        //¿©±â¼­ °ÔÀÓ ³¡³ª¸é ¹¹ ¶ß°Ô ÇÏÀÚ
        GameManager.instance.audioSource.volume = 0;
        PlayerAttack.canFire2 = false;
        GameManager.instance.playTimeText.text = string.Format("Å¬¸®¾î ½Ã°£ : {0}s ", (int)GameManager.instance.playtime);
    }
=======
>>>>>>> parent of bb77aac (í•˜ ì œê¸¸ ë˜ëŠ”ì¼ì´ í•˜ë‚˜ë„ ì—†ì–´..)
}
