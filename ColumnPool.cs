using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefab;
    private GameObject[] column;
    private int column_size = 5;
    private Vector2 objectPoolPos = new Vector2(-7.5f, -15f);
    float spawnX = 15f;
    float spawnRate=4f;
    float col_max = 2.5f;
    float col_min = -2.5f;
    float timesinceLastSpawned;
    int current = 0;
    private bool GameOver;
    void Start()
    {
        
        timesinceLastSpawned = 0f;
        column = new GameObject[column_size];
        for (int i = 0; i < column_size; i++)
            column[i] = (GameObject)Instantiate(columnPrefab,objectPoolPos, Quaternion.identity);
    }

    void Update()
    {
        GameOver = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().gameover;
        timesinceLastSpawned += Time.deltaTime;
       
        if(timesinceLastSpawned>=spawnRate&&(GameOver==false))
        {
            timesinceLastSpawned = 0f;
            float spawnY = Random.Range(col_max, col_min);
            column[current].transform.position = new Vector2(spawnX, spawnY);
            current++;
            if(current>=column_size)
            {
                current = 0;
            }
        }
    }
}
