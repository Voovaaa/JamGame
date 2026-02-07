using UnityEngine;

namespace JamGame
{

public class SoundEffects : MonoBehaviour
{
    public AudioSource effect;
    public AudioClip click;
    public AudioClip keyboard;
    public AudioClip error;
    public AudioClip finale;
    public AudioClip metalPanel;
    public AudioClip pop;
    public AudioClip drawer;
    public Mixer mixer;

    public void Break()
    {
        effect.Stop();
    }

    public void Play(string src)
    {
        effect.volume = 1f;
        effect.pitch = 1f;
        switch (src)
        {
            case "click": effect.PlayOneShot(click); break;
            case "keyboard": effect.PlayOneShot(keyboard); break;
            case "error": effect.PlayOneShot(error); break;
            case "pop": effect.PlayOneShot(pop); break;
            case "finale": {
                mixer.Pause();
                effect.PlayOneShot(finale); 
                break;
            }
            case "drawer": {
                effect.pitch = 1.5f;
                effect.PlayOneShot(drawer); 
                break;
            }
            case "metalPanel": {
                effect.volume = 0.7f;
                effect.PlayOneShot(metalPanel); 
                break;
            }
        }
    }

}
}
