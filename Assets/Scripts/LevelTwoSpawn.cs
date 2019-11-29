using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoSpawn : MonoBehaviour
{
    public GameObject meteorOne;
    public GameObject meteorTwo;
    public GameObject meteorThree;
    public GameObject enemy;
    public GameObject finish;

    private float leveltimer;
    private float enemytimer;
    private float enemyspawn;
    private float m1timer;
    private float m1spawn;
    private float m2timer;
    private float m2spawn;
 

    private int spawnWhich;
    private int spawnNum;
    private float randomspawntimer;
    // Start is called before the first frame update
    void Start()
    {
        leveltimer = 305;
        m1timer = 2;
        m1spawn = 0;
        m2timer = 4;
        m2spawn = 0;
        enemytimer = 5;
        enemyspawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy Spawn Loop
        enemytimer = enemytimer - Time.deltaTime;

        if (enemytimer < 1)
        {
            if (enemyspawn == 0)
            {
                Instantiate(enemy, new Vector3(100, -15, 0), transform.rotation);
            }
            if (enemyspawn == 1)
            {
                Instantiate(enemy, new Vector3(100, 0, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, -10, 0), transform.rotation);
            }
            if (enemyspawn == 2)
            {
                Instantiate(enemy, new Vector3(100, 10, 0), transform.rotation);
            }
            if (enemyspawn == 3)
            {
                Instantiate(enemy, new Vector3(100, -3, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, 11, 0), transform.rotation);
            }
            if (enemyspawn == 5)
            {
                Instantiate(enemy, new Vector3(100, 9, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, 3, 0), transform.rotation);
            }
            if (enemyspawn == 6)
            {
                Instantiate(enemy, new Vector3(100, -12, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, -3, 0), transform.rotation);
            }

            if (enemyspawn == 8)
            {
                Instantiate(enemy, new Vector3(100, 6, 0), transform.rotation);
            }
            if (enemyspawn == 9)
            {
                Instantiate(enemy, new Vector3(100, -13, 0), transform.rotation);
            }
            if (enemyspawn == 10)
            {
                Instantiate(enemy, new Vector3(100, 12, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, 0, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, -15, 0), transform.rotation);
            }
            enemyspawn = enemyspawn + 1;
            if (enemyspawn == 11)
            {
                enemyspawn = 0;
            }
            enemytimer = 10;
        }

        //Spawn Meteor one
        m1timer = m1timer - Time.deltaTime;

        if (m1timer < 1)
        {
            if (m1spawn == 0)
            {
                Instantiate(meteorThree, new Vector3(100, 8, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -4, 0), transform.rotation);
            }
            if (m1spawn == 1)
            {
                Instantiate(meteorTwo, new Vector3(100, 7, 0), transform.rotation);
            }
            if (m1spawn == 2)
            {
                Instantiate(meteorOne, new Vector3(100, -3, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -5, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -12, 0), transform.rotation);
            }
            if (m1spawn == 3)
            {
                Instantiate(meteorThree, new Vector3(100, 2, 0), transform.rotation);
            }
            if (m1spawn == 4)
            {
                Instantiate(meteorThree, new Vector3(100, 9, 0), transform.rotation);
            }
            if (m1spawn == 5)
            {
                Instantiate(meteorOne, new Vector3(100, -6, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -12, 0), transform.rotation);
            }
            if (m1spawn == 6)
            {
                Instantiate(meteorThree, new Vector3(100, 0, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -5, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 5, 0), transform.rotation);
            }
            if (m1spawn == 7)
            {
                Instantiate(meteorOne, new Vector3(100, 12, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -1, 0), transform.rotation);
            }
            if (m1spawn == 8)
            {
                Instantiate(meteorTwo, new Vector3(100, -13, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 0, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -9, 0), transform.rotation);
            }
            if (m1spawn == 9)
            {
                Instantiate(meteorOne, new Vector3(100, -10, 0), transform.rotation);
            }
            if (m1spawn == 10)
            {
                Instantiate(meteorThree, new Vector3(100, -13, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -14, 0), transform.rotation);
            }
            if (m1spawn == 11)
            {
                Instantiate(meteorTwo, new Vector3(100, 0, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 5, 0), transform.rotation);
            }
            if (m1spawn == 12)
            {
                Instantiate(meteorTwo, new Vector3(100, 1, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 11, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 2, 0), transform.rotation);
            }
            if (m1spawn == 13)
            {
                Instantiate(meteorOne, new Vector3(100, 11, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -10, 0), transform.rotation);
            }
            if (m1spawn == 14)
            {
                Instantiate(meteorThree, new Vector3(100, 8, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 4, 0), transform.rotation);
            }
            if (m1spawn == 15)
            {
                Instantiate(meteorThree, new Vector3(100, -15, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 11, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -4, 0), transform.rotation);
            }
            m1spawn = m1spawn + 1;
            if (m1spawn == 16)
            {
                m1spawn = 0;
            }
            m1timer = 5;
        }
        //Spawn Meteor two
        m2timer = m2timer - Time.deltaTime;

        if (m2timer < 1)
        {
            if (m2spawn == 0)
            {
                Instantiate(meteorTwo, new Vector3(100, -14, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 9, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -10, 0), transform.rotation);
            }
            if (m2spawn == 1)
            {
                Instantiate(meteorThree, new Vector3(100, -13, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 9, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, 12, 0), transform.rotation);
            }
            if (m2spawn == 2)
            {
                Instantiate(meteorTwo, new Vector3(100, -5, 0), transform.rotation);
            }
            if (m2spawn == 3)
            {
                Instantiate(meteorOne, new Vector3(100, 5, 0), transform.rotation);
            }
            if (m2spawn == 4)
            {
                Instantiate(meteorTwo, new Vector3(100, 11, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 5, 0), transform.rotation);
            }
            if (m2spawn == 5)
            {
                Instantiate(meteorThree, new Vector3(100, -15, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -12, 0), transform.rotation);
            }
            if (m2spawn == 6)
            {
                Instantiate(meteorThree, new Vector3(100, 9, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -4, 0), transform.rotation);
            }
            if (m2spawn == 8)
            {
                Instantiate(meteorOne, new Vector3(100, -12, 0), transform.rotation);
            }
            if (m2spawn == 9)
            {
                Instantiate(meteorTwo, new Vector3(100, 8, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -2, 0), transform.rotation);
            }
            if (m2spawn == 10)
            {
                Instantiate(meteorThree, new Vector3(100, 0, 0), transform.rotation);
            }
            if (m2spawn == 11)
            {
                Instantiate(meteorTwo, new Vector3(100, -14, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, 2, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -5, 0), transform.rotation);
            }
            if (m2spawn == 12)
            {
                Instantiate(meteorTwo, new Vector3(100, -3, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, 3, 0), transform.rotation);
            }
            if (m2spawn == 13)
            {
                Instantiate(meteorOne, new Vector3(100, -7, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 10, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 5, 0), transform.rotation);
            }
            m2spawn = m2spawn + 1;
            if (m2spawn == 14)
            {
                m2spawn = 0;
            }
            m2timer = 5;
        }
      

        //Medium element of random
        randomspawntimer = randomspawntimer - Time.deltaTime;
        if (randomspawntimer <= 1)
        {
            spawnMeteor();
            randomspawntimer = Random.Range(3,8);
        }

        //Spawn the finish
        leveltimer = leveltimer - Time.deltaTime;
        if (leveltimer <= 1)
        {
            Instantiate(finish, new Vector3(100, 0, 0), transform.rotation);
            leveltimer = 999;
        }
    }

    void spawnMeteor()
    {
            //Determine meteor's Y position 
            Vector2 position = new Vector2(100, Random.Range(-15, 12));
            Vector2 position2 = new Vector2(100, Random.Range(-15, 12));
            //Determine which meteor to spawn
            spawnWhich = Random.Range(1, 10);
            if (spawnWhich == 1)
            {
                Instantiate(meteorOne, position, transform.rotation);
            }
            if (spawnWhich == 2)
            {
                Instantiate(meteorTwo, position, transform.rotation);
            }
            if (spawnWhich == 3)
            {
                Instantiate(meteorThree, position, transform.rotation);
            }
            if (spawnWhich == 4)
            {
                Instantiate(meteorOne, position, transform.rotation);
                Instantiate(meteorOne, position2, transform.rotation);
            }
            if (spawnWhich == 5)
            {
                Instantiate(meteorTwo, position, transform.rotation);
                Instantiate(meteorTwo, position2, transform.rotation);
            }
            if (spawnWhich == 6)
            {
                Instantiate(meteorOne, position, transform.rotation);
                Instantiate(meteorThree, position2, transform.rotation);
            }
            if (spawnWhich == 7)
            {
                Instantiate(meteorOne, position, transform.rotation);
                Instantiate(meteorTwo, position2, transform.rotation);
            }
            if (spawnWhich == 8)
            {
                Instantiate(meteorTwo, position, transform.rotation);
                Instantiate(meteorThree, position2, transform.rotation);
            }
            if (spawnWhich == 9)
            {
                Instantiate(enemy, position, transform.rotation);
            }

        
    }
}

