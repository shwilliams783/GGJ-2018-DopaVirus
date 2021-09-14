using UnityEngine;
using System.Collections;



public class PlayerMove : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x -= 1 / speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += 1 / speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.y += 1 / speed;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y -= 1 / speed;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
