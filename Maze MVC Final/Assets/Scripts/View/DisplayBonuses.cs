using System;
using UnityEngine;
using UnityEngine.UI;


namespace Maze
{
    public sealed class DisplayBonuses
    {
        private Text _bonusLabel;

        public DisplayBonuses(GameObject bonus)
        {
            _bonusLabel = bonus.GetComponentInChildren<Text>();
            _bonusLabel.text = String.Empty;
        }

        public void Display(int value)
        {
            _bonusLabel.text = $"Вы набрали {value} очков";
        }
     
    }
}
