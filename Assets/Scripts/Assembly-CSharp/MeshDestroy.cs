using System.Collections.Generic;
using UnityEngine;

public class MeshDestroy : MonoBehaviour
{
	public class PartMesh
	{
		private List<Vector3> _Verticies;

		private List<Vector3> _Normals;

		private List<List<int>> _Triangles;

		private List<Vector2> _UVs;

		public Vector3[] Vertices;

		public Vector3[] Normals;

		public int[][] Triangles;

		public Vector2[] UV;

		public GameObject GameObject;

		public Bounds Bounds;

		public void AddTriangle(int submesh, Vector3 vert1, Vector3 vert2, Vector3 vert3, Vector3 normal1, Vector3 normal2, Vector3 normal3, Vector2 uv1, Vector2 uv2, Vector2 uv3)
		{
		}

		public void FillArrays()
		{
		}

		public void MakeGameobject(MeshDestroy original)
		{
		}

		public PartMesh()
			: base()
		{
		}
	}

	private bool edgeSet;

	private Vector3 edgeVertex;

	private Vector2 edgeUV;

	private Plane edgePlane;

	public int CutCascades;

	public float ExplodeForce;

	public void DestroyMesh()
	{
	}

	private PartMesh GenerateMesh(PartMesh original, Plane plane, bool left)
	{
		return null;
	}

	private void AddEdge(int subMesh, PartMesh partMesh, Vector3 normal, Vector3 vertex1, Vector3 vertex2, Vector2 uv1, Vector2 uv2)
	{
	}

	public MeshDestroy()
		: base()
	{
	}
}
