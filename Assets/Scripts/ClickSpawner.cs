using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpawner : MonoBehaviour
{
    float yLimit = 3.5f;

    void Update()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, 0);

            if (worldPoint.y > yLimit)
            {
                GameObject ball = ObjectPooler.SharedInstance.GetPooledObject();
                if(ball != null)
                {
                    ball.transform.position = adjustZ;
                    ball.SetActive(true);
                }
            }
            else { 
                Debug.LogWarning("No puedes spawnear objetos tan abajo");
            }
        }
    }
}
