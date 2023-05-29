using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    public GameObject[] rooms;
    public int level = 1;
    void Start()
    {
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
            Instantiate(rooms[random], pos, Quaternion.identity);
            pos.z += 10;            
        }

    }
}
