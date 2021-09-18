using UnityEngine;

namespace Magic_8.Scripts
{
    [CreateAssetMenu(fileName = "New Magic 8 Sayings", menuName = "New Magic 8")]
    public class Magic8Sayings : ScriptableObject
    {
        public string[] Positive,
                        Neutral,
                        Negative;
    }
}