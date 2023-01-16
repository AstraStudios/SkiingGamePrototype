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

    // Start is called before the first frame update
    void Start()
    {
        SelectTreeType();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectTreeType()
    {
        for(int i = 0; i < 100; i++)
        {
            spawnXAxis = Random.Range(-50, 50);
            spawnYAxis = Random.Range(0, -200);
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
}
