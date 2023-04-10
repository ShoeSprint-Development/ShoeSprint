using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    public GameObject block;
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
            block.GetComponent<BlockGenerator>().chance = Mathf.RoundToInt(100 / level) + 3;
            Instantiate(block, pos, Quaternion.identity);
            pos.z += 10;
        }

    }
}