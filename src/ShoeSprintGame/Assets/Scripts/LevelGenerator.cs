using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [Header("Resources for generating level")]
    public GameObject[] rooms;
    [Header("Final room")]
    public GameObject finalRoom;
    private int level;
    void Start()
    {
        LevelManager levelManager = FindObjectOfType<LevelManager>();
        level = levelManager.level;
        GenerateLevel();
    }

    private void GenerateLevel()
    {
        int blocks = level * 10;
        Vector3 pos = new Vector3(0, 0, 0);
        for (int i = 0; i < blocks; i++)
        {
            //choose random block from blocks
            int random = Random.Range(0, rooms.Length);
            if (i == blocks - 1) // Check if it's the last iteration of the loop
            {
                Instantiate(finalRoom, pos, Quaternion.identity);
            }
            else
            {
                Instantiate(rooms[random], pos, Quaternion.identity);
            }
            pos.z += 10;
        }

    }

}
