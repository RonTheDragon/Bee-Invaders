using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAster : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        StartCoroutine(AsteroidWave());
    }

    private void SpawnAs()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
    }

    IEnumerator AsteroidWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnAs();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
