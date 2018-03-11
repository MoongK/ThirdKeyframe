using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour {


    float rotationyy, rotationxx;
    float turnSpeed;
    

	void Start () {
        rotationyy = 0f;
        rotationxx = 0f;
        turnSpeed = 20f;
	}
	
	void Update () {
        float xx = Input.GetAxisRaw("Mouse X");
        float yy = Input.GetAxisRaw("Mouse Y");

        rotationyy += yy;
        rotationxx += xx * Time.deltaTime;
        float finalrotateyy = Mathf.Clamp(rotationyy, -30f, 45f);
        float finalrotatexx = Mathf.Clamp(rotationxx, -20f, 20f);

        //if (xx == 0f)
        //    finalrotatexx = 0f;

        //transform.localRotation = Quaternion.Euler(-finalrotateyy, finalrotatexx, 0f);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(-finalrotateyy, finalrotatexx, 0f), turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftControl))
        {
            print("Crouch!");
        }

    }
}
