using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerSprite : MonoBehaviour
{
    //Put on player empty
    [SerializeField] GameObject SkiierForward;
    [SerializeField] GameObject SkiierLeft;
    [SerializeField] GameObject SkiierRight;

    int currentSprite;

    // Start is called before the first frame update
    void Start()
    {
        currentSprite = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GetSpriteNum();
        ChangeSprite();
    }

    void GetSpriteNum()
    {
        //Forward facing
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentSprite = 1;
        }
        //Left facing
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentSprite = 2;
        }
        //Right facing
        if(Input.GetKeyDown(KeyCode.D))
        {
            currentSprite = 3;
        }
    }

    void ChangeSprite()
    {
        //Seems kinda ineffecient but this project shouldnt be long
        if (currentSprite == 1)
        {
            SkiierForward.SetActive(true);
            SkiierLeft.SetActive(false);
            SkiierRight.SetActive(false);
        }
        else if (currentSprite == 2)
        {
            SkiierForward.SetActive(false);
            SkiierLeft.SetActive(true);
            SkiierRight.SetActive(false);
        }
        else if (currentSprite == 3)
        {
            SkiierForward.SetActive(false);
            SkiierLeft.SetActive(false);
            SkiierRight.SetActive(true);
        }
    }
}
