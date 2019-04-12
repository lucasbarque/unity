using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollhorizontal : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 0.1f;
    public Renderer quad;
    void Start() {
        
    }
    
    void Update() {
        Vector2 offset = new Vector2(velocity * Time.deltaTime, 0);

        quad.material.mainTextureOffset += offset;
    }
}
