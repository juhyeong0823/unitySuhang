using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Boss : MonoBehaviour
{
    public List<SideObj> sideObjs = new List<SideObj>(); // 가장자리 4개 부시면 보스 때릴 수 있게

    public int hp;
    public static int damage = 10;
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
                {
                    Destroy(shield);
                }
                hp -= Player.damage;
                if (hp <= 0)
                {
                    Hitted();
                    clearUI.transform.position = this.transform.position;
                    clearUI.SetActive(true);    
                    // 이거 보스 죽는 애니메이션? 이펙트? 나오고 몇 초 뒤에 켜는거로 가보자
                    Destroy(this.gameObject);
                    //여기서 게임 끝나면 뭐 뜨게 하자
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
