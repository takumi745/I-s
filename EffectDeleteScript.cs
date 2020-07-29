using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDeleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeleteEffect", 2.0f);
    }

    // Update is called once per frame
    void DeleteEffect()
    {
        Destroy(gameObject);
    }
}
