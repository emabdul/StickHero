using System;

[AttributeUsage(AttributeTargets.Class)]
public class SingletonAttribute : Attribute
{
	public readonly string Name;

	public readonly bool IsDontDestroy;

	public SingletonAttribute(string _name, bool _isDontDestroy)
		: base()
	{
	}

	public SingletonAttribute(string _name)
		: base()
	{
	}
}
