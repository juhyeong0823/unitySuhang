using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    public int curHp = 3;
    public int maxHp = 3;

    public Image[] hpImage;
    public Sprite hurtedHeart;
    public GameObject die;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("EnemyBullet"))
        {
            col.gameObject.SetActive(false);

            if (curHp > 0)
            {
                curHp--;

                Hitted();
                hpImage[curHp].GetComponent<Image>().sprite = hurtedHeart;

            }
            CheckHp();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            if(curHp >0)
            {
                curHp--;

                Hitted();
                hpImage[curHp].GetComponent<Image>().sprite = hurtedHeart;
            }
            CheckHp();
        }
    }

    void CheckHp()
    {
        if (curHp <= 0)
        {
            die.transform.position = this.transform.position;
            die.SetActive(true);
            Invoke("DestroyRIP", 2f);
            Invoke("CvsClearOn", 3f);
            this.gameObject.SetActive(false);

        }
    }
     
    void DestroyRIP()
    {
        die.SetActive(false);

    }

    void CvsClearOn()
    {

        if (GameManager.instance.playtime > 60)
        {
            int minute = (int)GameManager.instance.playtime / 60;
            int sec = (int)GameManager.instance.playtime % 60;
            GameManager.instance.playTimeText.text = string.Format("ÇÃ·¹ÀÌ ½Ã°£ : {0}ºĞ {1}ÃÊ", minute, sec);
=======
    public int hp = 30;

    public static int damage = 5;

    WaitForSeconds sec1 = new WaitForSeconds(1f);

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("EnemyBullet"))
        {
            hp -= col.gameObject.GetComponent<MissileInfo>().damage;

            Hitted();

            if (col.gameObject.GetComponent<MissileInfo>().missileNum == 0)
                BossAttacker.bullets1.Enqueue(col.gameObject);

            col.gameObject.SetActive(false);
>>>>>>> parent of bb77aac (í•˜ ì œê¸¸ ë˜ëŠ”ì¼ì´ í•˜ë‚˜ë„ ì—†ì–´..)
        }
        else
        {
            GameManager.instance.playTimeText.text = string.Format("ÇÃ·¹ÀÌ ½Ã°£ : {0}ÃÊ", (int)GameManager.instance.playtime);
        }

        GameManager.instance.cvsClear.SetActive(true);

    }

    public void Hitted()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
<<<<<<< HEAD
        yield return GameManager.instance.sec1;
        this.GetComponent<SpriteRenderer>().color = Color.white;
=======
        yield return sec1;
>>>>>>> parent of bb77aac (í•˜ ì œê¸¸ ë˜ëŠ”ì¼ì´ í•˜ë‚˜ë„ ì—†ì–´..)
    }


}
