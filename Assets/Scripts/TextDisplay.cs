using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestDisapear());
    }

    IEnumerator TestDisapear()
    {
        yield return new WaitForSeconds(3f);


        Destroy(gameObject);    
    }
}
