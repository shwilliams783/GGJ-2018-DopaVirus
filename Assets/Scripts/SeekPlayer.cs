using UnityEngine;
using System.Collections.Generic;

public class SeekPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;

    void Start()
    {
        
        //Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //transform.rotation = Quaternion.LookRotation(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = Camera.main.WorldToScreenPoint(player.transform.position);
        transform.rotation = Quaternion.LookRotation(playerPos);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

}
