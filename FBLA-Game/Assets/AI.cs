using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public ArrayList questionBank;

    public Transform player; //The player

    public float walkingDistance = 50.0f; //The max distance at which the cat will detect the player

    public float smoothTime = 50.0f; //The amount of time it will take the cat to complete the maximum length journey between it and the player

    private Vector3 smoothVelocity = Vector3.zero;


    public float distance;//The speed of the cat

	void Start () {
        questionBank = new ArrayList();
        string[] questions = new string[6];
        questions[0] = "Do You Like FBLA?";
        questions[1] = "Yes";
        questions[2] = "No";
        questions[3] = "Maybe";
        questions[4] = "Not Sure";
        questions[5] = "no"; //whether this question has been used.
        questionBank.Add(questions);
        //Reassign and add
	}

    void Update() {
        transform.Rotate(0, 0, 0);

        distance = Vector3.Distance(transform.position, player.position);

        if (distance < walkingDistance)
        {
            //Make the cat look at the player
            transform.LookAt(player);
            transform.Rotate(transform.rotation.x, 90, transform.rotation.z);
            //Move the cat towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, 0.05f);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }

    }

    private void OnGUI()
    {
        if (distance < 0.5f)
        {
            Rect windowRect = new Rect(10, 10, 500, 200);
            windowRect = GUI.Window(0, windowRect, DoMyWindow, "Do you like FBLA?");
        }
        
    }

    void DoMyWindow(int windowID)
    {
        GUI.Button(new Rect(190, 40, 120, 60), "Yes");
        
    }
}
