using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldOfCubes : MonoBehaviour
{
    public GameObject cubePrefab;
    public int minCubes = 5;
    public int maxCubes = 10;
    public Vector3 extents;

    // Start is called before the first frame update
    void Start()
    {
        int numCubes = Random.Range(minCubes, maxCubes);
        for (int i = 0; i < numCubes; i++)
        {
            var inst = Instantiate(cubePrefab, new Vector3(Random.Range(-extents.x, extents.x), Random.Range(-extents.y, extents.y), Random.Range(-extents.z, extents.z)), Random.rotation);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position - extents, transform.position + extents, Color.blue);
    }
}
