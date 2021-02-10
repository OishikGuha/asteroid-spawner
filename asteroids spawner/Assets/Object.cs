using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{

    public float minSpeed = 0f;
    public float maxSpeed = 2f;

    float randomSpeed;


    void Start()
    {
        randomSpeed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(randomSpeed * Time.deltaTime, 0f),0f);
    }
}
