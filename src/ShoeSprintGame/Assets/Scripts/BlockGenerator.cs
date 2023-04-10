using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    //2D Array of GameObjects 3x3
    public GameObject[,] blocks = new GameObject[3, 3];
    public int chance;

    public GameObject[] Obstacles;


    // Start is called before the first frame update
    void Start()
    {
        GenerateBlocks();
        PlaceObjects();
    }

    void Update()
    {

    }
    public GameObject GetRandomGameObject(int chance, bool limited = false)
    {
        int random = Random.Range(0, chance);
        if (random < Obstacles.Length)
        {
            GameObject randomGameObject = Obstacles[random];
            if (limited && randomGameObject.name == "dvere"){
                return null;
            }
            return randomGameObject;
        }

        return null;
    }

    public void PlaceObjects()
    {
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (blocks[x, y] != null)
                {
                    Vector3 pos = this.gameObject.transform.position;
                    float posX = x * 2 + pos.x - 2;
                    float posZ = y * 2 + pos.z - 2;
                    GameObject obj = blocks[x, y];
                    Instantiate(obj, new Vector3(posX, 1, posZ), Quaternion.identity).transform.parent = this.gameObject.transform;
                }
            }
        }
    }

    public void GenerateBlocks()
    {
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                GameObject randomGameObject;
                //Generate random GameObject
                if (x == 0 || x == 2) randomGameObject = GetRandomGameObject(chance, true);
                else randomGameObject = GetRandomGameObject(chance);

                blocks[x, y] = randomGameObject;
            }
        }
    }
}
