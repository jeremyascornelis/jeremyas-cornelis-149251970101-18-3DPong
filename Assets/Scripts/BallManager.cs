using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBallAmount;
    public int spawnInterval;
    public List<GameObject> ballTemplateList;

    private List<GameObject> ballSpawnList;
    private float timer;

    private void Start()
    {
        ballSpawnList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnInterval)
        {
            if(ballSpawnList.Count <= maxBallAmount)
            {
                GenerateRandomBall();
                timer -= spawnInterval;
            }
            
        }
    }

    public void GenerateRandomBall()
    {
        if(ballSpawnList.Count >= maxBallAmount)
        {
            return;
        }

        int randomIndex = Random.Range(0, ballTemplateList.Count);
        GameObject ballUp = Instantiate(ballTemplateList[randomIndex], new Vector3(ballTemplateList[randomIndex].transform.position.x, ballTemplateList[randomIndex].transform.position.y, ballTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);

        ballUp.SetActive(true);

        ballSpawnList.Add(ballUp);
    }

    public void RemoveBall(GameObject ballUp)
    {
        ballSpawnList.Remove(ballUp);
        Destroy(ballUp);
    }

    public void RemoveAllBall()
    {
        while(ballSpawnList.Count > 0)
        {
            RemoveBall(ballSpawnList[0]);
        }
    }
}
