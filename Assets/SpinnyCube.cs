using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyCube : MonoBehaviour
{
    public float minSize = .2f;
    public float maxSize = 1f;
    public float minRotSpeed = .2f;
    public float maxRotSpeed = .5f;

    private Vector3 rotationAxis;
    private float rotationSpeed;
    void Start()
    {
        transform.localScale = Vector3.one * Random.Range(minSize, maxSize);
        rotationAxis = Random.onUnitSphere;
        rotationSpeed = Random.Range(minRotSpeed, maxRotSpeed);
    }

    private void Update()
    {
        transform.rotation = Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, rotationAxis) * transform.rotation;
    }
}
