using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CubeSpawner : MonoBehaviour
{ 
    public GameObject cubePrefab;

    public Button spawnButton;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnButton.onClick.AddListener(SpawnCube);


    }

    private void SpawnCube()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity /* keep rotation its already at */);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
