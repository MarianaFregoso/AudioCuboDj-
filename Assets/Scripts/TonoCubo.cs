using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonoCubo : MonoBehaviour
{
    [SerializeField]
    AudioVisualizer audioVisualizer;

    Vector3 initialScale;
    [SerializeField]
    float scaleFactor;
    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float freq = audioVisualizer.frequency;

        Vector3 newScale = new Vector3(freq, freq, freq) * scaleFactor;
        transform.localScale = newScale + initialScale;
    }
}
