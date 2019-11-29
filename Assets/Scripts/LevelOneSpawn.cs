using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSpawn : MonoBehaviour
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
    private float m3timer;
    private float m3spawn;

    private int spawnWhich;
    private int spawnNum;
    private float randomspawntimer;
    // Start is called before the first frame update
    void Start()
    {
        leveltimer = 185;
        m1timer = 3;
        m1spawn = 0;
        m2timer = 5;
        m2spawn = 0;
        m3timer = 7;
        m3spawn = 0;
        enemytimer = 10;
        enemyspawn = 0;
        Instantiate(meteorOne, new Vector3(60, 10, 0), transform.rotation);
        Instantiate(meteorTwo, new Vector3(100, 0, 0), transform.rotation);
        Instantiate(meteorThree, new Vector3(80, -11, 0), transform.rotation);
        Instantiate(enemy, new Vector3(100, 10, 0), transform.rotation);

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
                Instantiate(enemy, new Vector3(100, -10, 0), transform.rotation);
            }
            if (enemyspawn == 1)
            {
                Instantiate(enemy, new Vector3(100, 3, 0), transform.rotation);
            }
            if (enemyspawn == 2)
            {
                Instantiate(enemy, new Vector3(100, 8, 0), transform.rotation);
            }
            if (enemyspawn == 3)
            {
                Instantiate(enemy, new Vector3(100, 0, 0), transform.rotation);
            }
            if (enemyspawn == 4)
            {
                Instantiate(enemy, new Vector3(100, -7, 0), transform.rotation);
            }
            if (enemyspawn == 5)
            {
                Instantiate(enemy, new Vector3(100, -5, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, 5, 0), transform.rotation);
            }
            if (enemyspawn == 6)
            {
                Instantiate(enemy, new Vector3(100, 12, 0), transform.rotation);
                Instantiate(enemy, new Vector3(100, -15, 0), transform.rotation);
            }
            enemyspawn = enemyspawn + 1;
            if (enemyspawn == 7)
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
                Instantiate(meteorOne, new Vector3(100, 12, 0), transform.rotation);
            }
            if (m1spawn == 1)
            {
                Instantiate(meteorOne, new Vector3(100, 7, 0), transform.rotation);
            }
            if (m1spawn == 2)
            {
                Instantiate(meteorOne, new Vector3(100, -8, 0), transform.rotation);
            }
            if (m1spawn == 3)
            {
                Instantiate(meteorOne, new Vector3(100, 4, 0), transform.rotation);
            }
            if (m1spawn == 4)
            {
                Instantiate(meteorOne, new Vector3(100, 12, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -11, 0), transform.rotation);
            }
            if (m1spawn == 5)
            {
                Instantiate(meteorOne, new Vector3(100, -4, 0), transform.rotation);
            }
            if (m1spawn == 6)
            {
                Instantiate(meteorOne, new Vector3(100, 0, 0), transform.rotation);
            }
            if (m1spawn == 7)
            {
                Instantiate(meteorOne, new Vector3(100, -3, 0), transform.rotation);
            }
            if (m1spawn == 8)
            {
                Instantiate(meteorOne, new Vector3(100, -2, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 8, 0), transform.rotation);
            }
            if (m1spawn == 9)
            {
                Instantiate(meteorOne, new Vector3(100, -9, 0), transform.rotation);
            }
            if (m1spawn == 10)
            {
                Instantiate(meteorOne, new Vector3(100, 11, 0), transform.rotation);
            }
            if (m1spawn == 11)
            {
                Instantiate(meteorOne, new Vector3(100, -1, 0), transform.rotation);
            }
            if (m1spawn == 12)
            {
                Instantiate(meteorOne, new Vector3(100, 3, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, 0, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -8, 0), transform.rotation);
            }
            if (m1spawn == 13)
            {
                Instantiate(meteorOne, new Vector3(100, -7, 0), transform.rotation);
                Instantiate(meteorOne, new Vector3(100, -12, 0), transform.rotation);
            }
            m1spawn = m1spawn + 1;
            if (m1spawn == 14)
            {
                m1spawn = 0;
            }
            m1timer = 7;
        }
        //Spawn Meteor two
        m2timer = m2timer - Time.deltaTime;

        if (m2timer < 1)
        {
            if (m2spawn == 0)
            {
                Instantiate(meteorTwo, new Vector3(100, -4, 0), transform.rotation);
            }
            if (m2spawn == 1)
            {
                Instantiate(meteorTwo, new Vector3(100, -5, 0), transform.rotation);
            }
            if (m2spawn == 2)
            {
                Instantiate(meteorTwo, new Vector3(100, 2, 0), transform.rotation);
            }
            if (m2spawn == 3)
            {
                Instantiate(meteorTwo, new Vector3(100, 5, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 10, 0), transform.rotation);
            }
            if (m2spawn == 4)
            {
                Instantiate(meteorTwo, new Vector3(100, -4, 0), transform.rotation);
            }
            if (m2spawn == 5)
            {
                Instantiate(meteorTwo, new Vector3(100, 4, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, -13, 0), transform.rotation);
            }
            if (m2spawn == 6)
            {
                Instantiate(meteorTwo, new Vector3(100, -9, 0), transform.rotation);
            }
            if (m2spawn == 7)
            {
                Instantiate(meteorTwo, new Vector3(100, 4, 0), transform.rotation);
            }
            if (m2spawn == 8)
            {
                Instantiate(meteorTwo, new Vector3(100, 11, 0), transform.rotation);
            }
            if (m2spawn == 9)
            {
                Instantiate(meteorTwo, new Vector3(100, 8, 0), transform.rotation);
            }
            if (m2spawn == 10)
            {
                Instantiate(meteorTwo, new Vector3(100, -11, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, -2, 0), transform.rotation);
            }
            if (m2spawn == 11)
            {
                Instantiate(meteorTwo, new Vector3(100, -14, 0), transform.rotation);
            }
            if (m2spawn == 12)
            {
                Instantiate(meteorTwo, new Vector3(100, -15, 0), transform.rotation);
            }
            if (m2spawn == 13)
            {
                Instantiate(meteorTwo, new Vector3(100, -8, 0), transform.rotation);
                Instantiate(meteorTwo, new Vector3(100, 11, 0), transform.rotation);
            }
            m2spawn = m2spawn + 1;
            if (m2spawn == 14)
            {
                m2spawn = 0;
            }
            m2timer = 7;
        }
        //Spawn Meteor three
        m3timer = m3timer - Time.deltaTime;

        if (m3timer < 1)
        {
            if (m3spawn == 0)
            {
                Instantiate(meteorThree, new Vector3(100, 1, 0), transform.rotation);
            }
            if (m3spawn == 1)
            {
                Instantiate(meteorThree, new Vector3(100, 6, 0), transform.rotation);
            }
            if (m3spawn == 2)
            {
                Instantiate(meteorThree, new Vector3(100, 8, 0), transform.rotation);
            }
            if (m3spawn == 3)
            {
                Instantiate(meteorThree, new Vector3(100, -9, 0), transform.rotation);
            }
            if (m3spawn == 4)
            {
                Instantiate(meteorThree, new Vector3(100, 1, 0), transform.rotation);
            }
            if (m3spawn == 5)
            {
                Instantiate(meteorThree, new Vector3(100, -3, 0), transform.rotation);
            }
            if (m3spawn == 6)
            {
                Instantiate(meteorThree, new Vector3(100, 4, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -15, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -8, 0), transform.rotation);
            }
            if (m3spawn == 7)
            {
                Instantiate(meteorThree, new Vector3(100, 6, 0), transform.rotation);
            }
            if (m3spawn == 8)
            {
                Instantiate(meteorThree, new Vector3(100, -10, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, 0, 0), transform.rotation);
            }
            if (m3spawn == 9)
            {
                Instantiate(meteorThree, new Vector3(100, 5, 0), transform.rotation);
            }
            if (m3spawn == 10)
            {
                Instantiate(meteorThree, new Vector3(100, -2, 0), transform.rotation);
            }
            if (m3spawn == 11)
            {
                Instantiate(meteorThree, new Vector3(100, 12, 0), transform.rotation);
            }
            if (m3spawn == 12)
            {
                Instantiate(meteorThree, new Vector3(100, -5, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, -15, 0), transform.rotation);
            }
            if (m3spawn == 13)
            {
                Instantiate(meteorThree, new Vector3(100, 2, 0), transform.rotation);
                Instantiate(meteorThree, new Vector3(100, 8, 0), transform.rotation);
            }
            m3spawn = m3spawn + 1;
            if (m3spawn == 14)
            {
                m3spawn = 0;
            }
            m3timer = 7;
        }


        //Small element of random
        randomspawntimer = randomspawntimer - Time.deltaTime;
        if(randomspawntimer <=1)
        {
            spawnMeteor();
            randomspawntimer = Random.Range(5, 10);
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
        //Determine how many meteors spawn
        spawnNum = Random.Range(1, 2);
        for (int i = 0; i < spawnNum; i++)
        {
            //Determine meteor's Y position 
            Vector2 position = new Vector2(100, Random.Range(-15, 12));
            //Determine which meteor to spawn
            spawnWhich = Random.Range(1, 4);
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

        }
    }
}