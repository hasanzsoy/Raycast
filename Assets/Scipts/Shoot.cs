using UnityEngine;
using UnityEngine.Rendering;

public class Shoot : MonoBehaviour
{
    public float rayDistance;
    public LayerMask enemyLayerMask;
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward); // baktığı yöndeki objeleri tespit etmek için bir ışın oluşturuyoruz
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // mouse'un ekran üzerindeki konumundan bir ışın oluşturuyoruz, bu sayede mouse ile tıklanan objeleri tespit edebiliriz

        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit,rayDistance))
            {
                if(hit.collider.CompareTag("Target"))
                {
                    hit.collider.GetComponent<Renderer>().material.color = Color.yellow;
                    //Destroy(hit.collider.gameObject); //oyundan silme kodu
                }
            }
        }
    }

    //private void OnDrawGizmos()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // mouse'un ekran üzerindeki konumundan bir ışın oluşturuyoruz, bu sayede mouse ile tıklanan objeleri tespit edebiliriz
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawRay(ray.origin, ray.direction * 100); // ışını görselleştiriyoruz, böylece nereden nereye gittiğini görebiliriz
    //}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * rayDistance; // kameranın baktığı yönde bir vektör oluşturuyoruz
        Gizmos.DrawRay(transform.position, direction); // ışını görselleştiriyoruz, böylece nereden nereye gittiğini görebiliriz

        //drawsphere ile ışının çarptığı noktayı görselleştirebiliriz BUNU ARAŞTIRMAK GEREKİR
    }
}
