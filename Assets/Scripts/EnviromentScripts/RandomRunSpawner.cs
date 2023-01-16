using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRunSpawner : MonoBehaviour
{
    [SerializeField] GameObject treeStyleOne;
    [SerializeField] GameObject treeStyleTwo;
    [SerializeField] GameObject treeStyleThree;

    int treeStyle;
    float spawnXAxis;
    float spawnYAxis;

    [SerializeField] GameObject bushStyleOne;
    [SerializeField] GameObject bushStyleTwo;
    [SerializeField] GameObject bushStyleThree;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTrees();
        SpawnBushes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTrees()
    {
        for(int i = 0; i < 100; i++)
        {
            //Maybe make more tight
            spawnXAxis = Random.Range(-15, 15);
            spawnYAxis = Random.Range(0, -50);
            treeStyle = Random.Range(0, 4);
            switch(treeStyle)
            {
                case 1:
                    Instantiate(treeStyleOne, new Vector3(spawnXAxis, spawnYAxis, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(treeStyleTwo, new Vector3(spawnXAxis, spawnYAxis, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(treeStyleThree, new Vector3(spawnXAxis, spawnYAxis, 0), Quaternion.identity);
                    break;
            }

        }
    }

    void SpawnBushes()
    {
        for (int i = 0; i < 50; i++)
        {
            int bushStyle;
            bushStyle = Random.Range(0, 4);
            float spawnXAxis;
            float spawnYAxis;
            spawnXAxis = Random.Range(-15, 15);
            spawnYAxis = Random.Range(0, -50);
            switch(bushStyle)
            {
                case 1:
                    Instantiate(bushStyleOne, new Vector3(spawnXAxis, spawnYAxis, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(bushStyleTwo, new Vector3(spawnXAxis, spawnYAxis, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bushStyleThree, new Vector3(spawnXAxis, spawnYAxis, 0), Quaternion.identity);
                    break;
            }
        }
    }
}
