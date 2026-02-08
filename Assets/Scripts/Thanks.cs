using UnityEngine;


    public class Thanks : MonoBehaviour
    {
        public Splash splash;
        public SoundEffects se;

        public void Go()
        {
            se.Play("click");
            this.gameObject.SetActive(false);
            this.splash.Activate();
        }
    }
 
