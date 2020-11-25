using UnityEngine;

namespace GBhomework
{
    public sealed class Extention : MonoBehaviour
    {
        public int count = 10;
        public int offset = 1;
        public GameObject Object;

        public float SliderValue;
        private Transform _root;

        private void Start()
        {
            CreateObject();
        }

        public void CreateObject()
        {
            _root = new GameObject("Root").transform;

            for (var i = 1; i <= count; i++)
            {
                Instantiate(Object, new Vector3(0, offset * i, 0), Quaternion.identity, _root);
            }
        }

        public void AddComponent()
        {
            gameObject.AddComponent<Rigidbody>();
            gameObject.AddComponent<MeshRenderer>();
            gameObject.AddComponent<BoxCollider>();
        }

        public void RemoveComponent()
        {
            DestroyImmediate(GetComponent<Rigidbody>());
            DestroyImmediate(GetComponent<MeshRenderer>());
            DestroyImmediate(GetComponent<BoxCollider>());
        }




    }
}
