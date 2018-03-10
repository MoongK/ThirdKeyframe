using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        float x = Input.GetAxisRaw("Mouse X");
        float y = Input.GetAxisRaw("Mouse Y");

        float maxrotation = 45f;
        float minrotation = -45f;
        Vector3 currentrotation = transform.localRotation.eulerAngles;
        currentrotation.x = Mathf.Clamp(currentrotation.x, minrotation, maxrotation);


        //transform.Find("Head").transform.localRotation = Quaternion.Euler(currentrotation);

        transform.Rotate(Vector3.up * x * 50f * Time.deltaTime);
	}
}
