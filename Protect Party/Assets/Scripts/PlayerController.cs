using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private float activeMoveSpeed=2f;
    public float mousesensitivity = 2f;
    CharacterController player;
    public Collider Guard;

    public GameObject eyes;

    public float hp;

    float moveFB;
    float moveLR;

    float rotX;
    float rotY;
	// Use this for initialization
	void Start () {
        player = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        moveFB = Input.GetAxis("Vertical") * activeMoveSpeed;
        moveLR = Input.GetAxis("Horizontal") * activeMoveSpeed;

        rotX = Input.GetAxis("Mouse X") *mousesensitivity;
        rotY = Input.GetAxis("Mouse Y")*mousesensitivity;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(-rotY, 0, 0);

        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);


        
    }
}
