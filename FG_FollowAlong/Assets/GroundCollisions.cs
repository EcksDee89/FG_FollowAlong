using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        return color;
    }
}
