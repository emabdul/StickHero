using System;
using System.Runtime.CompilerServices;

[Serializable]
public class AppInfo
{
	public string Id;

	public string AppId { get; set; }

	public string PackageName { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string IconURL { get; set; }

	public int Gold { get; set; }

	public string URL { get; set; }

	public string Display_App { get; set; }

	public int zOrder { get; set; }

	public AppInfo()
		: base()
	{
	}
}
