using UnityEngine;
using System.Collections;

public class SpawnExit : MonoBehaviour {

    public GameObject levelExit;

	// Use this for initialization
	void Start () {
        StartCoroutine(CreateExit());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator CreateExit()
    {
        yield return new WaitForSeconds(23);
        GameObject newExit = (GameObject)Instantiate(levelExit, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
