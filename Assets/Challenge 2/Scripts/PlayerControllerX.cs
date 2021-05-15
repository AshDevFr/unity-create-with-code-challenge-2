using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool hasDog = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (!hasDog && Input.GetKeyDown(KeyCode.Space))
        {
            hasDog = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("ResetHasDog", 1.0f);
        }
    }

    void ResetHasDog()
    {
        hasDog = false;
    }
}
