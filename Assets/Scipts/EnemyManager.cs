using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private void Start()
    {
        //Instantiate(enemyPrefab, transform.position, transform.rotation); // transform.position, objenin pozisyonunu, EnemyManager objesinin pozisyonuna göre oluşturur, yani EnemyManager objesi hareket ettirilmişse, oluşturulan obje de aynı şekilde hareket ettirilmiş olur
        //Instantiate(enemyPrefab, new Vector3(5, 20, 4), transform.rotation); // transform.rotation, objenin rotasyonunu, EnemyManager objesinin rotasyonuna göre oluşturur, yani EnemyManager objesi döndürülmüşse, oluşturulan objede aynı şekilde döndürülür
        //Instantiate(enemyPrefab, new Vector3(0, 0.97f, 0), Quaternion.identity); // Quaternion.identity, objenin rotasyonunu sıfırlar, yani objenin kendi eksenlerine göre döndürülmemiş bir şekilde oluşturulmasını sağlar
        //Instantiate(enemyPrefab, new Vector3(2,3, 0), Quaternion.identity);
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(enemyPrefab, new Vector3(0, 0.97f, 0), transform.rotation);
        }

        for (int i = 0; i < 5; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 0.97f, Random.Range(-5f, 5f));
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            // her frame'de rastgele bir pozisyonda düşman oluşturur,
            // bu yüzden çok fazla düşman oluşabilir ve performans sorunlarına yol açabilir,
            // bu yüzden bu kodu dikkatli kullanmak gerekir
        }
    }
}
