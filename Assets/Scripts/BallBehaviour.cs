using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    float yLimit = -7.0f;
    void Update()
    {
        if(transform.position.y < yLimit)
        {
            StartCoroutine("DisableObject");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Receptor") { 
            ++ScoreManager.score;
            StartCoroutine("DisableObject");
        }
    }

    IEnumerator DisableObject()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
    }
}
