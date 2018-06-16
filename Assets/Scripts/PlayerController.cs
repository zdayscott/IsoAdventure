using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5f;

    public float rotationSpeed = 5f;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horzInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

		if(horzInput != 0 || vertInput != 0)
        {
            Vector3 movDir = new Vector3(horzInput, 0, vertInput);
            this.transform.Translate(movDir * speed, Space.World);

            Quaternion lookRotation = Quaternion.LookRotation(movDir);
            Vector3 rotation = Quaternion.Lerp(this.transform.rotation, lookRotation, rotationSpeed * Time.deltaTime).eulerAngles;
            this.transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        }
	}
}
