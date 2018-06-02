using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateGUI : MonoBehaviour {

    public Spawner spawn;
    // Use this for initialization
    public void GUI()
    {
        GetComponent<TextMeshPro>().SetText(""+spawn.points);
    }
}
