using UnityEngine;
using UnityEditor;

namespace GBhomework
{

    [CustomEditor(typeof(Extention))]
    public class EditorExtention : UnityEditor.Editor
    {
        private bool _isPressButtonOk;

        public override void OnInspectorGUI()
        {
            Extention extentionTarget = (Extention)target;

            extentionTarget.count = EditorGUILayout.IntSlider(extentionTarget.count, 10, 50);
            extentionTarget.offset = EditorGUILayout.IntSlider(extentionTarget.offset, 1, 5);

            extentionTarget.Object =
            EditorGUILayout.ObjectField("Объект который хотим вставить", extentionTarget.Object, typeof(GameObject), false) as GameObject;

            var isPressButton = GUILayout.Button("Создание объектов по кнопке", EditorStyles.miniButtonLeft);
            _isPressButtonOk = GUILayout.Toggle(_isPressButtonOk, "Ok");

            if (isPressButton)
            {
                extentionTarget.CreateObject();
                _isPressButtonOk = true;
            }

            if (_isPressButtonOk)
            {
                extentionTarget.SliderValue = EditorGUILayout.Slider(extentionTarget.SliderValue, 10, 50);
                EditorGUILayout.HelpBox("Вы нажали на кнопку", MessageType.Warning);

                var isPressAddButton = GUILayout.Button("Add Component", EditorStyles.miniButtonLeft);
                var isPressRemoveButton = GUILayout.Button("Remove Component", EditorStyles.miniButtonLeft);

                if (isPressAddButton)
                {
                    extentionTarget.AddComponent();
                }
                if (isPressRemoveButton)
                {
                    extentionTarget.RemoveComponent();
                }


            }
        }
    }
}
   
