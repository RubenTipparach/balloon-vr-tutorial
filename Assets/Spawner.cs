using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public int points;
    public int pointsPerBalloon;
    public float rate;
    public GameObject prefab;
    public float range;
    float TheTimer=0;
    public void AddPoints()
    {
        points += pointsPerBalloon;
        var x = GameObject.FindObjectsOfType<UpdateGUI>();
        foreach (var item in x)
        {
            item.GUI();
        }
    }

	void Update () {
        TheTimer += Time.deltaTime;
        if (TheTimer >= rate)
        {
            TheTimer = 0;
            GameObject.Instantiate(prefab, new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range)),Quaternion.identity);
        }
	}
}
