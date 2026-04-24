using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private void Start()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation); // transform.position, objenin pozisyonunu, EnemyManager objesinin pozisyonuna göre oluşturur, yani EnemyManager objesi hareket ettirilmişse, oluşturulan obje de aynı şekilde hareket ettirilmiş olur
        Instantiate(enemyPrefab, new Vector3(5, 20, 4), transform.rotation); // transform.rotation, objenin rotasyonunu, EnemyManager objesinin rotasyonuna göre oluşturur, yani EnemyManager objesi döndürülmüşse, oluşturulan objede aynı şekilde döndürülür
        Instantiate(enemyPrefab, new Vector3(5, 20, 4), Quaternion.identity); // Quaternion.identity, objenin rotasyonunu sıfırlar, yani objenin kendi eksenlerine göre döndürülmemiş bir şekilde oluşturulmasını sağlar
    }
}
