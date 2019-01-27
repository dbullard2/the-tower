using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {

	public Camera camera;

	private Vector3 lastPosition;
	Vector3 delta;

	Rigidbody rb;

  public float speed = 3.5f;
  public float panSpeed;
	public float sensitivity;

	private float X;
  private float Y;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		if(Input.GetAxis("Mouse ScrollWheel") > 0f ){ //mouse wheel scrolls forward
			camera.transform.position += (transform.forward * speed);
		}

		if(Input.GetAxis("Mouse ScrollWheel") < 0f ){ //mouse wheel scrolls backward
			camera.transform.position += (-transform.forward * speed);
		}

		if(Input.GetMouseButton(1)){
			transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * panSpeed, Input.GetAxis("Mouse X") * speed, 0));
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);
		}

		if(Input.GetMouseButtonDown(2)){
			lastPosition = Input.mousePosition;
			Debug.Log(lastPosition);
		}

		if(Input.GetMouseButton(2)){
			delta = Input.mousePosition - lastPosition;
			transform.Translate(delta.x * sensitivity * -1, delta.y * sensitivity * -1, delta.z * sensitivity * -1);
			lastPosition = Input.mousePosition;
		}
	}
}
