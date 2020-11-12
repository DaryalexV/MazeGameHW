using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Task3Test : MonoBehaviour
{
    private void Start()
    {
        List<int> list = new List<int>() { 7, 4, 8, 5, 2, 6, 4, 1, 2, 7 };
        Dictionary<int, int> result = Lists<int>.countFrequency(list);
        foreach (KeyValuePair<int, int> pair in result)
        {
            Debug.Log($"{pair.Key} встречается {pair.Value} раз.");
        }
       
    }
    public static class Lists<T>
    {
        public static Dictionary<T, int> countFrequency(List<T> list)
        {
            Dictionary<T, int> result = new Dictionary<T, int>();

            List<T> aux = list.Distinct().ToList();

            foreach (T item in aux)
            {
                int num = 0;
                foreach (T externalItem in list)
                {
                    if (externalItem.Equals(item))
                    {
                        num++;
                    }
                }
                result.Add(item, num);
            }

            return result;
        }
    }
}
