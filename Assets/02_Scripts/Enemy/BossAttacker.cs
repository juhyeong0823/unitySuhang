using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttacker : MonoBehaviour
{
    public GameObject[] weapons;


    private int rand;
    private bool CanAttack = false;

    public Transform bossRotate;
    public Transform bulletPool;

    public static Queue<GameObject> bullets1 = new Queue<GameObject>(); // ¿øÇü ¼¦
    //public static Queue<GameObject> bullets2 = new Queue<GameObject>(); // µ¹¸é¼­ ½î±â

    private WaitForSeconds sec1 = new WaitForSeconds(1f);
    private WaitForSeconds zero5 = new WaitForSeconds(0.5f);
    private WaitForSeconds sec5 = new WaitForSeconds(5f);


    private void OnEnable()
    {
        CanAttack = false;
        StartCoroutine(SetCanAttack());
    }

    // ÀÌ¶§ È­¸é Àá±ñ ²ô´Â ´À³¦À¸·Î ÆäÀÌµå
    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject obj = Instantiate(weapons[0], transform.position, Quaternion.identity);
            bullets1.Enqueue(obj);
            obj.SetActive(false);
            obj.transform.parent = bulletPool.transform;
        }
        this.transform.parent.transform.parent.gameObject.SetActive(false);
    }

    void Update()
    {
        if (CanAttack && OnBoss.objsCanAttack)
        {
            RandomAttack();
        }
    }

    void RandomAttack()
    {
        rand = Random.RandomRange(0, 3);

        if (rand >= 0)
        {
            StartCoroutine(CircleShoot());


            CanAttack = false;
            StartCoroutine(SetCanAttack());
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }



        IEnumerator CircleShoot()
        {
            GameObject obj = null;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 18; i++)
                {
                    if (bullets1.Count <= 0)
                    {
                        obj = obj = Instantiate(weapons[0], transform.position,Quaternion.identity);
                        bullets1.Enqueue(obj);
                    }
                    obj = bullets1.Dequeue();
                    obj.transform.position = this.transform.position;
                    obj.SetActive(true);
                    obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(Mathf.Cos(Mathf.PI * 2 * i / 18), Mathf.Sin(Mathf.PI * i * 2 / 18)) * 100f);
                }
                

                yield return sec1;
            }
        }


    }
    IEnumerator SetCanAttack()
    {
        yield return sec5;
        CanAttack = true;
    }
}
