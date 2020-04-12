using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject mine;

    // Start is called before the first frame update
    void Start()
    {        
        

        int randomMine = Random.Range(7, 10);

        Vector2 posMax = getCameraSiteMax();
        Vector2 posMin = getCameraSiteMin();

        Vector3 randomPos = new Vector3();

        float randomX;
        float randomY;

        

        for(int index = 0; index < randomMine; ++index)
        {
            randomX = Random.RandomRange(posMin.x + 0.5f, posMax.x - 0.5f);
            randomY = Random.RandomRange(posMin.y + 0.5f, posMax.y - 0.5f);

            Instantiate(mine);

            GameObject objj = (GameObject)Instantiate(mine, new Vector3(randomX, randomY, 0), Quaternion.identity);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector2 getCameraSiteMin ()
    {
        return Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
    }

    public Vector2 getCameraSiteMax ()
    {
        return Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
    }
}

/*
 * 
 * 
 * Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
*/