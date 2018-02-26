using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour {

    public GameObject[] cats;
    public GameObject cat;

	// Use this for initialization
	void Start () {
        cat = GameObject.FindGameObjectWithTag("Respawn");
	}
	
	// Update is called once per frame
	void Update () {
        cats = GameObject.FindGameObjectsWithTag("Respawn");
        if (cats.Length < 15)
        {
            spawnCat();
        }
        else if (cats.Length > 15)
        {
            //kill a cat
        }
    }
    void spawnCat()
    {
        //find Random x and y coordinates within a certain radius
        //Random xcoord = new Random(-10, 10);

        Instantiate(cat, cats[1].transform.position, cats[1].transform.rotation);
    }
}
