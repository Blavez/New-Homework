using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public AudioSource caughtAudio;

    bool m_IsPlayerCaught;
    float m_Timer;
    bool m_HasAudioPlayed;



    public void CaughtPlayer()
    {
        m_IsPlayerCaught = true;
    }

    void Update()
    {
        if (m_IsPlayerCaught)
        {
            EndLevel( true, caughtAudio);
        }
    }

    void EndLevel( bool doRestart, AudioSource audioSource)
    {
        if (!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;
        }

            if (doRestart)
            {
                SceneManager.LoadScene(1);
            }
    }
}
