using UnityEngine;
using System.Collections;

public class LightFader : MonoBehaviour
{
    public float duration = 1.0F;
    public Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
    }
    void Update()
    {
        float phi = (Time.time / duration * 2 * Mathf.PI) - (duration / 2) + 1;
        float amplitude = Mathf.Sin(phi) * 0.5F + 0.5F;
        lt.intensity = amplitude;
    }
}