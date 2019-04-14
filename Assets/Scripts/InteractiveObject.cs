using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("text that will display in the UI when the player look at this object in the world.")]
    [SerializeField]
    protected string displayText = nameof (InteractiveObject);

    public virtual string DisplayText => displayText;
    protected AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    public virtual void InteractWith()
    {
        try
        {
            audioSource.Play();
        }
        catch (System.Exception)
        {
            throw new System.Exception("Missing AudioSource component or audio clip: Interactive object requires an AudioSource component with an audioClip assigned.");
        }
        Debug.Log($"Player just interacted with {gameObject.name}");
    }
}
