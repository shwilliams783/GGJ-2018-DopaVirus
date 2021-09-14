using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        
    }
}