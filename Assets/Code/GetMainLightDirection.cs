using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GetMainLightDirection : MonoBehaviour
{
    [SerializeField] private Material skyboxMaterial;
    private void Update()
    {
        skyboxMaterial.SetVector(name = "_MainLightDirector", transform.forward);

    }
}
