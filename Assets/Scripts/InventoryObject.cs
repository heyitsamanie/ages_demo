using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{
    [Tooltip("Name of the object as it will appear in the inventory menu UI.")]
    [SerializeField]
    private string objectName = nameof(InventoryObject);

    //TODO: add long description field
    //TODO: add icon field

    public string ObjectName => objectName;

    private new Renderer renderer;
    private new Collider collider;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }

    public InventoryObject()
    {
        displayText = $"Take {objectName}";
    }

    /// <summary>
    /// When a player interats with an inventory object we need to do 2 things:
    /// 1.) Add the inventory object to the PlayerInventory list
    /// 2.) Remove the objec from the game world / scene
    ///     can't use Destroy because I need to keep the gameObject in the inventory List.
    ///     so we just disable the collider and renderer.
    /// </summary>
    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.InventoryObjects.Add(this);
        renderer.enabled = false;
        collider.enabled = false;

    }
}
