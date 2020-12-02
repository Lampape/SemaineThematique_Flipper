using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorOnPressKey : MonoBehaviour
{
    public GameObject Droite;
    public GameObject Gauche;
    public Color feedBombe;
    private Material materialG;

    private Color startColor; 
    // Start is called before the first frame update
    void Start()
    {
        startColor = materialG.GetColor("_EmissionColor");
        materialG = Gauche.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        materialG.SetColor("_EmissionColor",startColor);
        if (Input.GetKeyDown(KeyCode.A))
        {
            materialG.SetColor("_EmissionColor",feedBombe);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
        }
    }
}
