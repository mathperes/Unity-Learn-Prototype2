using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canUse = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canUse)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canUse = false;
            StartCoroutine(SpawnDelay());
        }
        

        IEnumerator SpawnDelay()
        {
            yield return new WaitForSeconds(1);
            canUse = true;
        }
    }
}
