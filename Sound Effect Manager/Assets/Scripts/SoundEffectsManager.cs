using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Create a singleton Sound Effects Manager that will be used to channel and direct all sound effects
/// </summary>
public class SoundEffectsManager : MonoBehaviour
{

    private static SoundEffectsManager m_instance;

    /// <summary>
    /// For everything else to be able to access the instance of Sound Effects Manager
    /// </summary>
    public static SoundEffectsManager Instance
    {
        get
        {
            return m_instance;
        }
    }

    /// <summary>
    /// Make sure there is only one Sound Effects Manager active throughout the play
    /// </summary>
    private void Awake()
    {
        if (m_instance == null)
        {
            m_instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);  
    }

    public static void PlaySound()
    {

    }
}
