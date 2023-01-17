using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    // Just something for my brother, save for last. He made the art for it and he wanted this(Dont priotize)
    [SerializeField] GameObject MonsterStand;
    [SerializeField] GameObject MonsterRun;
    [SerializeField] GameObject MonsterPunch;

    [SerializeField] GameObject player;

    float playerPositionX;
    float playerPositionY;

    float monsterSpeed;
    float currentWalkAnim = 1.01f;

    Vector2 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        MonsterStand.SetActive(true);
        MonsterRun.SetActive(false);
        MonsterPunch.SetActive(false);

        playerPositionX = player.transform.position.x;
        playerPositionY = player.transform.position.y;

        monsterSpeed = 1 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        ChangeSprite();
        playerPositionX = player.transform.position.x;
        playerPositionY = player.transform.position.y;
    }

    void FollowPlayer()
    {
        playerPosition.x = playerPositionX;
        playerPosition.y = playerPositionY;

        gameObject.transform.position = Vector2.MoveTowards(transform.position, playerPosition, monsterSpeed);
    }

    void ChangeSprite()
    {
        ChangeWalkSprite();
    }

    void ChangeWalkSprite()
    {
        if (currentWalkAnim > 1 && currentWalkAnim < 2)
        {
            MonsterStand.SetActive(true);
            MonsterRun.SetActive(false);
        }
        if (currentWalkAnim > 2 && currentWalkAnim < 3)
        {
            MonsterStand.SetActive(false);
            MonsterRun.SetActive(true);
        }
        currentWalkAnim += .01f * Time.deltaTime;
    }
}
