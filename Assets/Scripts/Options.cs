using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
    {
        public Mixer mixer;
        public SoundEffects se;

        public Toggle t;

        public void Activate()
        {
            this.gameObject.SetActive(true);
        }

        public void SetAudio()
        {
            se.Play("Click");

            if (t.isOn)
            {
                this.mixer.Play();                
            }
            else
            {
                this.mixer.Pause();     
            }
        }

        public void Back()
        {
            se.Play("Click");
            this.gameObject.SetActive(false);
        }
    }
