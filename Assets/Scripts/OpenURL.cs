using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenURL : MonoBehaviour
{
    public void AssetButton()
    {

        Application.OpenURL("https://github.com/heyitsamanie/ages_demo/blob/master/README.md");
    }
}
