using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFish : MonoBehaviour
{
    GameObject[] fishs;
    float interval = 2.0f;
    float timer = 0.0f;

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        checkFishNum();
        if(fishs.Length < 5 && timer > interval)
        {
            Instantiate(obj, getRandomPos(), Quaternion.identity);
            timer = 0.0f;
        }
    }

    int checkFishNum()
    {
        fishs = GameObject.FindGameObjectsWithTag("Fish");
        return fishs.Length;
    }

    Vector3 getRandomPos()
    {
        float x = Random.Range(-8.6f, 8.6f);
        float y = Random.Range(-3.6f, 3.6f);
        return new Vector3(x, y, 0.0f);
    }


}
