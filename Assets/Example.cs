using UnityEngine;


public class Example : MonoBehaviour 
{
    public int OriginalNumber;
    bool condition;
    void Start()
    {
        HasProperties hp = new HasProperties();
        hp.MyFloat = 5f;
        Debug.Log(hp.MyFloat);
        Debug.Log(hp.HalfFloat);
        Debug.Log((Compare(hp.MyFloat, hp.HalfFloat).ToString()));
    }

    public float Compare(float a, float b)
    {
        return (a < b) ? a : b;
    }


    public class HasProperties
    {
        protected float myFloat;
        public float MyFloat
        {
            get
            { return myFloat; }
            set
            { myFloat = value; }
        }
        public float HalfFloat
        {
            get
            { return this.myFloat/2; }
            set
            { this.myFloat = value/2; }
        }

    }
}