using UnityEngine;

namespace JamGame
{
   
    public class MainMenu : MonoBehaviour
    {
        public Game game;
        public Options options;
        public SoundEffects se;

        public void Activate()
        {
            this.gameObject.SetActive(true);
        }

        public void NewGame()
        {
            se.Play("click");
            game.Initialize();
            this.gameObject.SetActive(false);
        }

        public void Options()
        {
            se.Play("click");
            this.options.Activate();
        }

        public void Quit()
        {
            se.Play("click");
            Application.Quit();
        }
    }
 
}
