using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public GameObject playerObj;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        clapm();   
    }

    // Update is called once per frame
    void Update()
    {
        if(checkPosX(transform.position.x))
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }

        if(checkPosY(transform.position.y))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        }

        clapm();
        //transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }

    public bool checkPosX (float x)
    {
        if(playerObj.transform.position.x < x)
        {
            return true;
        }

        return false;
    }
    public bool checkPosY(float y)
    {
        if (playerObj.transform.position.y < y)
        {
            return true;
        }

        return false;
    }

    public void clapm ()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        Vector2 playerPos = transform.position;

        playerPos.x = Mathf.Clamp(playerPos.x, min.x + 0.5f, max.x - 0.5f);
        playerPos.y = Mathf.Clamp(playerPos.y, min.y + 0.5f, max.y - 0.5f);

        transform.position = playerPos;
    }
}


/*
 맵 이탈 방지
 */