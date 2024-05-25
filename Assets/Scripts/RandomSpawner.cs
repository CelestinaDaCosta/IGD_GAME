using System.Collections;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject obstacle;
    //(y position) Shoulder height of the player to define the position of obstacles 
    public float playerHeight = 0f;
    //(x position) when the LEFT arm is stretched out
    public float playerLeft = -1f;
    //(x position) when the RIGHT arm is stretched out
    public float playRight = 1f;

    public GameObject completeLevelUI; 

    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        while (!completeLevelUI.activeSelf)
        {
            //Here we instatiate new obstacle on the left.
            Vector3 spawnLeftPosition = new Vector3(playerLeft, Random.Range(playerHeight-0.3f, playerHeight+0.3f), 20);
            Instantiate(obstacle, spawnLeftPosition, Quaternion.identity);
            //Here we instatiate new obstacle on the left.
            Vector3 spawnRightPosition = new Vector3(playRight, Random.Range(playerHeight-0.3f, playerHeight+0.3f), 20);
            Instantiate(obstacle, spawnRightPosition, Quaternion.identity);
            //repeat every .5 sec. 
            yield return new WaitForSeconds(.3f);
        }
    }
}
