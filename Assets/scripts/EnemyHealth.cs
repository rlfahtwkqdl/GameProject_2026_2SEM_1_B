using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 30;
    [SerializeField] private int currentHealth;

    //아이템 드롭 관련 함수 추가
    [SerializeField] private GameObject dropItemPrefab;
    [SerializeField] private Vector3 dropOffset = new Vector3(0f, 0.5f, 0f);
    private bool isDead;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        Debug.Log(name + " 남은 체력 : " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()                           //사망시 드롭 아이템을 생성 한다.
    {
        isDead = true;

        if (dropItemPrefab != null)
        {
            Instantiate(dropItemPrefab, transform.position + dropOffset, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
