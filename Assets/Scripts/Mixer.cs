using System.Collections;
using UnityEngine;



public class Mixer : MonoBehaviour
{
    public AudioSource[] sources;
    Coroutine playing;

    public void Play()
    {
        playing = StartCoroutine(PlayAndDetectEnd());
    }

    public void Pause()
    {
        if(playing != null) StopCoroutine(playing);
        foreach (AudioSource a in sources)
        {
            a.Stop();
        }
    }

    IEnumerator PlayAndDetectEnd() {
        while (true)
        {
            for(int i = 0; i < sources.Length; i++)
            {
                sources[i].Play();
                yield return new WaitUntil(() => !sources[i].isPlaying);
            }
        }
    }
}

