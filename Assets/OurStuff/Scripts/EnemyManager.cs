using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemmies;
    public int seconds;
    public Text end;
    public Text show;
    private int enemycount;
    private Enemy enemy;
    private bool check = true;

    void Start()
    {
        //create an array of obj with tag Enemy
        enemmies = GameObject.FindGameObjectsWithTag("Enemy");

        
        enemy = enemmies[Random.Range(0, enemycount)].GetComponent<Enemy>();
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        enemmies = GameObject.FindGameObjectsWithTag("Enemy");
        enemycount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        show.text = "Enemy count: " + enemycount;
        if (enemycount <= 0 )
        {
            end.text = "You Won\n Next LVL?\n Press Enter";
            check = false;
            LvlUp();
        }
    }

    IEnumerator Spawn()
    {
        while (check)
        {
            enemy = enemmies[Random.Range(0, enemycount)].GetComponent<Enemy>();
            yield return new WaitForSeconds(seconds);
            if (enemy.tov == true)
            {
                enemy.SpawnAs();
            }
            
        }

    }

    void LvlUp()
    {
        if(Input.GetKey(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
