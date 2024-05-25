using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject completeLevelUI;
    public float playTime = 20f;
    
    void Start()
    {
        completeLevelUI.SetActive(false);
        StartCoroutine(CompleteLevel());
    }

    // When the level is completed (e.g. timer is up), a random scene gets loaded. 
    IEnumerator CompleteLevel()
    {
        // wait for 20 seconds 
        //TODO Change to timer 
        yield return new WaitForSeconds(playTime);

        completeLevelUI.SetActive(true);

        yield return new WaitForSeconds(2.3f);
        int index = Random.Range(0,4);
        SceneManager.LoadScene(index);
    }
}
