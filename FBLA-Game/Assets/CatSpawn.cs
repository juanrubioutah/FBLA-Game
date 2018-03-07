using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CatSpawn : MonoBehaviour {
    
    public GameObject[] tempCats;
    public GameObject cat;
    public GameObject player;
    public float killDistance;
    public List<GameObject> cats;

	// Use this for initialization
	void Start () {
        tempCats = GameObject.FindGameObjectsWithTag("Respawn");
        cat = GameObject.FindGameObjectWithTag("Respawn");
        player = GameObject.FindGameObjectWithTag("Player");

        cats = tempCats.ToList();

        killDistance = 50;
	}
	
	// Update is called once per frame
	void Update () {
        tempCats = GameObject.FindGameObjectsWithTag("Respawn");
        cats = tempCats.ToList();
        
        for(int i = 0; i < cats.Count; i++)
        {
            if(Vector3.Distance(cats[i].transform.position, player.transform.position) > killDistance)
            {
                killCat(i);
            }
        }
        if (cats.Count < 3)
        {
            spawnCat();
        }
        else if (cats.Count > 3)
        {
            killCat(0);
        }
    }
    void spawnCat()
    {
        Vector3 randomCatPosition = new Vector3(Random.Range(-10.0f, 10.0f) + player.transform.position.x+2, player.transform.position.y, Random.Range(-10.0f, 10.0f) + player.transform.position.z+2);
        cat = GameObject.FindGameObjectWithTag("Respawn");
        Instantiate(cat, randomCatPosition, player.transform.rotation);
    }
    void killCat(int whichCat)
    {
        Destroy(cats[whichCat]);
    }

}
