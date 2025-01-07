using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
	[SerializeField]
	private float _value;
	[SerializeField]
	private float _hearts;
	[SerializeField]
	private float _highscore;
	public float Value
	{
		get { return _value; }
		set { _value = value; }
	}
    public float Hearts
    {
        get { return _hearts; }
        set { _hearts = value; }
    }
    public float Highscore
	{
		get { return _highscore; }
		set { _highscore = value; }
	}
}
