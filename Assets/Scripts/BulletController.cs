using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
        StartCoroutine(SelfDestruct());
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
