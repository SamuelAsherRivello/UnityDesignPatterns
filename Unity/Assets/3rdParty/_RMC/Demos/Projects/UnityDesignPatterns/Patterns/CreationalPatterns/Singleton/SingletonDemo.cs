﻿using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.Singleton
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class SingletonDemo : MonoBehaviour
	{
		protected void Start()
		{
			Singleton.Instance.SayHelloWorld();
			Singleton.Instance.SayHelloWorld();
		}
	}
}