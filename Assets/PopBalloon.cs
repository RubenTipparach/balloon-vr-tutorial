using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopBalloon : MonoBehaviour {

	public void Popped()
    {
        GameObject.FindObjectOfType<Spawner>().AddPoints();
    }
}
