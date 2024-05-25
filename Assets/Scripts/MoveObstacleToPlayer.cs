using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float speed = 20;

    // Update is called once per frame
    private void Update()
    {
        //Obstacles move towards to the player with a defined speed. 
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
