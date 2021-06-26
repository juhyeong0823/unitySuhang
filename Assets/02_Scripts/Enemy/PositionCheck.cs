using UnityEngine;

public class PositionCheck : MonoBehaviour
{
    int num;

    private void Start()
    {
        num = this.gameObject.GetComponent<MissileInfo>().missileNum;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("Wall"))
        {
            if (num == 0)
            {
                BossAttacker.bullets1.Enqueue(this.gameObject);
            }

            this.gameObject.SetActive(false);

        }
    }
}
