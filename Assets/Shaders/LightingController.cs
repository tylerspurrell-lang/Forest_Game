
using UnityEngine;

public class LightingController : MonoBehaviour
{
    [Header("Objects to Change")]
    public Renderer[] targetObjects;

    [Header("Lighting Materials")]
    public Material unlitMaterial;
    public Material ambientMaterial;
    public Material diffuseMaterial;
    public Material specularMaterial;
    public Material fullLightingMaterial;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SetLighting(unlitMaterial, "No Lighting");

        if (Input.GetKeyDown(KeyCode.Alpha2))
            SetLighting(ambientMaterial, "Ambient + Diffuse");

        if (Input.GetKeyDown(KeyCode.Alpha3))
            SetLighting(diffuseMaterial, "Specular Only");

        if (Input.GetKeyDown(KeyCode.Alpha4))
            SetLighting(specularMaterial, "Ambient + Specular");

        if (Input.GetKeyDown(KeyCode.Alpha5))
            SetLighting(fullLightingMaterial, "Ambient + Specular + Rim");
    }

    void SetLighting(Material material, string modeName)
    {
        if (material == null)
        {
            Debug.LogWarning("Missing material for mode: " + modeName);
            return;
        }

        if (targetObjects == null || targetObjects.Length == 0)
        {
            Debug.LogWarning("Assign at least one target object.");
            return;
        }

        foreach (Renderer target in targetObjects)
        {
            if (target != null)
                target.sharedMaterial = material;
        }

        Debug.Log("Lighting Mode: " + modeName);
    }
}
