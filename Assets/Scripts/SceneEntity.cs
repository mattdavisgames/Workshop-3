// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class SceneEntity : MonoBehaviour
{
    public virtual RaycastHit? Intersect(Ray ray)
    {
        // Use the Unity Engine to calculate ray-entity intersection.
        // The built-in "Collider" component (base class) handles this for us:
        // - https://docs.unity3d.com/ScriptReference/Collider.html
        return null;


        //var coll = GetComponentInChildren<Collider>();
        //var isHit = coll.Raycast(ray, out var hit, float.PositiveInfinity);
        //return isHit ? hit : null;
    }
    
    public Color Color()
    {
        return GetComponentInChildren<MeshRenderer>()?.material.color 
               ?? UnityEngine.Color.white; // Default color is white
    }
}
