using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Animator))]
public class Door : InteractiveObject
{
    [Tooltip("Check this box to lock the door.")]
    [SerializeField]
    private bool isLocked;

    [Tooltip("The text displayed when the player looks at the door when it's locked.")]
    [SerializeField]
    private string lockedDisplayText = "Locked";

    [Tooltip("Play this AudioClip when the player interacts with a locked door without owning the key.")]
    [SerializeField]
    private AudioClip lockedAudioClip;

    [Tooltip("Play this AudioClip when the player opens the door.")]
    [SerializeField]
    private AudioClip openAudioClip;

    public override string DisplayText => isLocked ? lockedDisplayText : base.DisplayText;

    private Animator animator;
    private bool isOpen = false;
    private int shouldOpenAnimParameter = Animator.StringToHash(nameof(shouldOpenAnimParameter));
    private int shouldCloseAnimParameter = Animator.StringToHash(nameof(shouldCloseAnimParameter));

    /// <summary>
    /// Using a contructor here to initialize display text in the editor
    /// </summary>
    public Door()
    {
        displayText = nameof(Door);
    }

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (!isLocked)
            {
                audioSource.clip = openAudioClip;
                animator.SetBool(shouldOpenAnimParameter, true);
                displayText = string.Empty;
                isOpen = true;
            }
            else // If the door is locked ...
            {
                audioSource.clip = lockedAudioClip;
            }

            base.InteractWith(); // This plays a sound effect!
        }

        //else
        //{
        //    base.InteractWith();
        //    animator.SetBool(shouldCloseAnimParameter, true);
        //    displayText = string.Empty;
        //    isOpen = false;
        //}
    }
}
