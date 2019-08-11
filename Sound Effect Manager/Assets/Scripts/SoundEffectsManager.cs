using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Create a singleton Sound Effects Manager that will be used to channel and direct all sound effects
/// </summary>
public class SoundEffectsManager : MonoBehaviour
{

    private static SoundEffectsManager m_instance;

    private static AudioSource m_audioSource;

    [SerializeField]
    private AudioClip m_fireSound;

    [SerializeField]
    private AudioClip m_alternateSound;

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

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// General sound player when passed
    /// </summary>
    /// <param name="m_soundClip"></param>
    public void PlaySound(SOUNDEFFECTTYPE m_soundClip)
    {
        switch (m_soundClip)
        {
            case SOUNDEFFECTTYPE.FirstOption:
                m_audioSource.PlayOneShot(m_fireSound);
                break;
            case SOUNDEFFECTTYPE.SecondOption:
                m_audioSource.PlayOneShot(m_alternateSound);
                break;
        }
    }

    /// create different type of sound players, maybe one for collision (that takes velocity, and force of rb) - where multiple can be played once
    /// one for constant source that will not be impacted by factors - the lerping of target spot - when a new target spot is collected
    /// one for ui related events - pausing, unpausing, when someone scores a point?, time at certain points, the movement of ui on the pause/end scene
}
