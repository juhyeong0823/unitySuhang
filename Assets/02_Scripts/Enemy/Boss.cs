using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Boss : MonoBehaviour
{
    public List<SideObj> sideObjs = new List<SideObj>(); // 가장자리 4개 부시면 보스 때릴 수 있게

    public float curHp = 15;
    public float maxHp = 15;

    public Slider hpbar;

    public static int damage = 5;
    public GameObject clearUI;
    public GameObject shield;

    WaitForSeconds sec1 = new WaitForSeconds(1f);
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
                if(shield != null)
                    Destroy(shield);

                this.curHp -= col.gameObject.GetComponent<DirectBullet>().damage;
                hpbar.value = (float)curHp / (float)maxHp;
                Hitted();

                if (curHp <= 0)
                {
                    clearUI.transform.position = this.transform.position;
                    clearUI.SetActive(true);    
                    // 이거 보스 죽는 애니메이션? 이펙트? 나오고 몇 초 뒤에 켜는거로 가보자
                    Destroy(this.gameObject);
                    //여기서 게임 끝나면 뭐 뜨게 하자

                    GameManager.instance.audioSource.volume = 0;
                    PlayerAttack.canFire2 = false;
                }
            }
            Destroy(col.gameObject);
        }
    }

    public void Hitted()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(wait());
        this.GetComponent<SpriteRenderer>().color = Color.black;
    }

    IEnumerator wait()
    {
        yield return sec1;
    }

    public void RemoveTop(SideObj removeObj) // 걍 맨 첫번째거 지우는거
    {
        sideObjs.Remove(removeObj);
    }





}
