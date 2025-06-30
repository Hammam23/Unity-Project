
using UnityEngine;
public class ObstacleCleaner : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < Camera.main.transform.position.x - 15f)
        {
            Destroy(gameObject);
        }
    }
}
