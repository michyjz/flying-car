using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankSpawnScript : MonoBehaviour
{
    public GameObject plank;
    public GameObject coin;
    public GameObject cloud;
    public GameObject bomb;
    public float spawnRate = 3;
    public float timer = 0;
    public float heightOffset = 6;

    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
    }

    void spawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 plankPos = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
        float degree = Random.Range(-45, 45);
        Quaternion plankRot = Quaternion.Euler(0, 0, degree);
        Instantiate(plank, plankPos, plankRot);

        int numCoins = Random.Range(0, 4);
        for (float i = 0; i < numCoins; i++)
        {
            float height = plankPos.y + 2 + (i * degree / 22);
            Instantiate(coin, new Vector3(plankPos.x - (numCoins-1) + i*2, height, 0), Quaternion.Euler(0, 0, 0));
        }

        Vector3 cloudPos = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
        Instantiate(cloud, cloudPos, Quaternion.Euler(0, 0, 0));

        Vector3 bombPos = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
        Instantiate(bomb, bombPos, Quaternion.Euler(0, 0, 0));
    }
}
