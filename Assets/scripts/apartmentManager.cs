using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apartmentManager : MonoBehaviour {

    public GameObject[] apartments;

    void Start(){
      apartments = GameObject.FindGameObjectsWithTag("apartments");
      //apartments[1].transform.position = Vector3.zero;
      apartment apartment0 = apartments[0].GetComponent<apartment>();
      apartment0.available = true;
    }

    // Update is called once per frame
    void Update(){
    }
}
