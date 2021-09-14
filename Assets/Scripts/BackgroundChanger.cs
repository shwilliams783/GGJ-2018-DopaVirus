using UnityEngine;
using System.Collections;

public class BackgroundChanger : MonoBehaviour {

    public GameObject background;

	// Use this for initialization
	void Start () {
        StartCoroutine(ChangeBackground());
    }

    IEnumerator ChangeBackground()
    {
        yield return new WaitForSeconds(4);
        GameObject.Destroy(background);
    }
}
