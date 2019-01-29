using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject npc;

    void Start() {
        Instantiate(npc, new Vector3(-670.1849f, 81.29999f, 446.6f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
