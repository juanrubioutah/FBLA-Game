using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawn : MonoBehaviour {

    public GameObject[] cats;
    public GameObject cat;


	// Use this for initialization
	void Start () {
        cats = GameObject.FindGameObjectsWithTag("Respawn");
        cat = GameObject.FindGameObjectWithTag("Respawn");
	}
	
	// Update is called once per frame
	void Update () {
        cats = GameObject.FindGameObjectsWithTag("Respawn");
        if (cats.Length < 3)
        {
            spawnCat();
        }
        else if(cats.Length > 3)
        {
            killCat();
        }
	}
    void spawnCat()
    {
        Instantiate(cat, cats[0].transform.position, cats[0].transform.rotation);
    }
    void killCat()
    {
        Destroy(cats[0]);
    }

}
