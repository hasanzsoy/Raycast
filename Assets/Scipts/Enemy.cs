using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private void Start()
    {
        StartCoroutine(Wave());
    }

    IEnumerator Wave()
    {
        while (true) 
        {
            for (int i = 0; i < 5; i++)
            {
                Debug.Log("Karakter Oluşturuldu");
                SpawnEnemy();
                yield return new WaitForSeconds(2f);
            }
            Debug.Log("Yeni Dalga Başlıyor");
            yield return new WaitForSeconds(5f);
        }
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f),0.97f,Random.Range(-5f, 5f));
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}

