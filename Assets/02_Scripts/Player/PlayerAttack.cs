using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerAttack : MonoBehaviour
{
    enum AttackState
    {
        normal,
        shotgun,
        snipe
    };

    AttackState state;


    PlayerItems items;

    public GameObject playerItems;
    public GameObject crosshair;
    public Transform bulletStartpos;


    private WaitForSeconds zero1 = new WaitForSeconds(0.1f);
    private WaitForSeconds _1 = new WaitForSeconds(1f);
    private WaitForSeconds _2 = new WaitForSeconds(2f);

    [SerializeField]
    private Transform shooter; // gunShooter의 로테이트 참조하기

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject snipeBullet;

    private bool canFire = true;
    public static bool isShooting;

    public GameObject bulletPool;

    public string leftClick = "Fire1";

    public float speed;
    private void Start()
    {
        state = AttackState.normal;
        items = playerItems.GetComponent<PlayerItems>();
    }

    void Update()
    {
        Attack();
        WeaponChange();
    }



    void Attack()
    {
        if (Input.GetButton(leftClick) && canFire)
        {
            isShooting = true;
            crosshair.SetActive(true);

            if (state == AttackState.normal) Fire1();
            else if (state == AttackState.shotgun) Fire2();
            else if (state == AttackState.snipe) Fire3();
        }
        else if(Input.GetButtonUp(leftClick))
        {
            isShooting = false;
        }

        #region
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if(items.item1[0] != null)
            {
                GameObject obj = items.item1[0];
                 items.item1.Remove(obj);
                Instantiate(obj, transform.position, shooter.rotation);
               
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (items.item2.Count > 0)
            {
                GameObject obj = items.item2[0];
                Instantiate(obj, transform.position, shooter.rotation);
                items.item2.Remove(obj);
            }

        }
        #endregion

    }


    void WeaponChange()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) state = AttackState.normal;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) state = AttackState.shotgun;
        else if (Input.GetKeyDown(KeyCode.Alpha3)) state = AttackState.snipe;
    }

    void Fire1()
    {
        GameObject obj = Instantiate(bullet, bulletStartpos.position, shooter.rotation);
        obj.transform.parent = bulletPool.transform;
        canFire = false;
        StartCoroutine(Wait1());
    }

    void Fire2()
    {
        Quaternion rotate = shooter.rotation;

        for (int i = -1; i < 2; i++)
        {
            GameObject obj = Instantiate(bullet, bulletStartpos.position, shooter.rotation);
            obj.transform.Rotate(0, 0, i*7f);
            obj.transform.parent = bulletPool.transform;
        }
        canFire = false;
        StartCoroutine(Wait2());
    }

    void Fire3()
    {
        GameObject obj = Instantiate(bullet, bulletStartpos.position, shooter.rotation);
        obj.transform.parent = bulletPool.transform;

        canFire = false;
        StartCoroutine(Wait3());
    }


    IEnumerator Wait1()
    {
        yield return zero1;
        canFire = true;
    }

    IEnumerator Wait2()
    {
        yield return _1;
        canFire = true;
    }

    IEnumerator Wait3()
    {
        yield return _2;
        canFire = true;
    }



}
