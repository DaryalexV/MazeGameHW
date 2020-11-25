using UnityEditor;
using UnityEngine;

namespace GBhomework
{
    public class MenuItems : MonoBehaviour
    {
        [MenuItem("Homework/Создать объекты")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Homework");
        }
  
    }
}