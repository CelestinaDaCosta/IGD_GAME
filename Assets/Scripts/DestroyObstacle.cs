using UnityEngine;


public class DestroyObstacle : MonoBehaviour
{
    public float zValue = -10f;

    // Update is called once per frame
    void Update()
    {
        // when the obstacle is outside of the range, it gets destroyed. 
        if (transform.position.z <= zValue)
        {
            Destroy(gameObject);
        }
    }
}
