using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {


    public Transform player; //The player

    public float walkingDistance = 10.0f; //The max distance at which the cat will detect the player

    public float smoothTime = 10.0f; //The amount of time it will take the cat to complete the maximum length journey between it and the player

    private Vector3 smoothVelocity = Vector3.zero; //The speed of the cat

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 0);

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < walkingDistance)
        {
            //Make the cat look at the player
            transform.LookAt(player);
            transform.Rotate(transform.rotation.x, 90, transform.rotation.z);
            //Move the cat towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, 0.05f);
        }
	}
}
