using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{

    [SerializeField] MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void ChangeColor()
    {
        meshRenderer.material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
