using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuestISP2k
{
    internal class Scenes
    {

        int _sceneNumber = 0;
        string _scenePrompt = "";

        public Scenes() { }

        /// <summary>
        /// Конструктор класса сцены.
        /// </summary>
        /// <param name="number">номер сцены.</param>
        /// <param name="prompt">описание сцены.</param>
        public Scenes(int number, string prompt) 
        {
            _sceneNumber = number;
            _scenePrompt = prompt;
        } 
        

        public int SceneNumber { get { return _sceneNumber; } set { _sceneNumber = value;  } }
        public string ScenePrompt { get
            {            
                return ">>>> " + _scenePrompt; 
            } set { _scenePrompt = value; } }
        public void PrintPrompt() { Console.WriteLine(ScenePrompt); }
    }
}
