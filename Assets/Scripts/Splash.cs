using UnityEngine;

namespace JamGame
{
   
    public class Splash : MonoBehaviour
    {
        public MainMenu mainMenu;
        public Mixer mixer;
        public SoundEffects se;

        void Start()
        {
            Activate();
        }

        public void Go()
        {
            se.Play("click");
            this.gameObject.SetActive(false);
            this.mainMenu.Activate();
        }

        public void Activate()
        {
            this.mixer.Play();
        }
    }
 
}