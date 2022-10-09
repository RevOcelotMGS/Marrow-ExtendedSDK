using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace RayFire.DotNet
{
	public class RFShatter
	{
		public enum GeneralParams
		{
			world_tm = 1,
			absolute_error = 2,
			relative_error = 3,
			mapping_tm = 4,
			pre_shatter = 5,
			pre_weld = 6,
			pre_weld_threshold = 7,
			pre_cap = 8,
			glue = 9,
			relax = 10,
			tessellate = 11,
			maping_scale = 12,
			restore_normals = 13,
			delete_collinear = 14,
			max_precision = 15,
			material_id = 16,
			glue_weld_threshold = 17,
			explode_glue = 18,
			explode_by_elements = 19,
			explode_decompose = 20,
			decompose_simple_out_mesh = 21,
			editor_mode_separate_only = 22,
			editor_mode_pre_cap = 23,
			editor_mode_min_bbox_diag_size_filter = 24,
			editor_mode_elliminateCollinears_maxIterFuse = 25,
			editor_mode_exclude_inside = 26,
			editor_mode_remove_double_faces = 27,
			editor_mode_remove_inversed_double_faces = 28,
			editor_mode_remove_cap_faces = 29,
			minFacesFilter = 30,
			post_weld = 31,
			post_normals_smooth = 32,
			meshRemoveMinFaceFilter = 33,
			editor_mode_meshRemoveMinFaceFilter = 34
		}

		public enum FragmentParams
		{
			enabled = 10001,
			type = 10002,
			tm = 10003,
			bbox_size = 10004,
			mesh_tm = 10005,
			seed = 10006,
			max_element_amount = 10007,
			stretching = 10008,
			tetra_type = 10009,
			tetra1_density = 10010,
			tetra2_density = 10011,
			tetra_offset = 10012,
			tetra_noise = 10013,
			voronoi_type = 10014,
			voronoi_uni_num = 10015,
			voronoi_uni_noise = 10016,
			voronoi_irr_num = 10017,
			voronoi_irr_noise_type = 10018,
			voronoi_irr_noise_frequence = 10019,
			voronoi_irr_noise_low = 10020,
			voronoi_irr_noise_high = 10021,
			voronoi_irr_noise_roughness = 10022,
			voronoi_rad_radius = 10023,
			voronoi_rad_divergence = 10024,
			voronoi_rad_restrict = 10025,
			voronoi_rad_rings_count = 10026,
			voronoi_rad_rings_focus = 10027,
			voronoi_rad_rings_strenght = 10028,
			voronoi_rad_rings_random = 10029,
			voronoi_rad_rays_count = 10030,
			voronoi_rad_rays_random = 10031,
			voronoi_rad_rays_twist = 10032,
			voronoi_custom_points = 10033,
			voronoi_object_obj_list = 10034,
			voronoi_object_percentage = 10035,
			voronoi_object_spline_step = 10036,
			voronoi_object_spline_limit = 10037,
			voronoi_object_divergence = 10038,
			voronoi_irr_bias = 10039,
			voronoi_custom_bias = 10040,
			bricks_points = 10041,
			bricks_normals = 10042,
			bricks_num_bricks = 10043,
			bricks_brick_size = 10044,
			bricks_offsets = 10045,
			bricks_random_size = 10046,
			bricks_random_split = 10047,
			brick_slice_probability = 10048,
			brick_slice_offset = 10049,
			brick_slice_rotate = 10050
		}

		public enum ClusterParams
		{
			enabled = 30001,
			tm = 30002,
			center_tm = 30003,
			texture_tm = 30004,
			by_texture_enabled = 30005,
			by_texture_map = 30006,
			by_texture_tile = 30007,
			by_texture_threshold = 30008,
			by_texture_black_as_debris = 30009,
			by_radial_count = 30010,
			by_half_count = 30011,
			by_half_variation = 30012,
			by_pcloud_count = 30013,
			options_angle_chaos = 30014,
			options_noise_scale = 30015,
			options_noise_strength = 30016,
			options_bias = 30017,
			options_seed = 30018,
			options_use_damage = 30019,
			debris_count = 30020,
			debris_layers_count = 30021,
			debris_tessellate = 30022,
			debris_scale = 30023,
			debris_remove = 30024,
			debris_min = 30025,
			debris_max = 30026,
			preview_scale = 30027,
			preview_color = 30028
		}

		public enum RFShatterMode
		{
			classic = 0,
			vorosimple = 1,
			slicesimple = 2,
			bricksimple = 3
		}

		public struct safeMeshData
		{
			public int geom_verts_size;

			public int geom_faces_size;

			public int uv_verts_size;

			public int uv_faces_size;

			public int normal_verts_size;

			public int normal_faces_size;

			public int color_verts_size;

			public int color_faces_size;

			public float[] geom_verts;

			public float[] uv_verts;

			public float[] normal_verts;

			public float[] color_verts;

			public int[] geom_faces;

			public int[] uv_faces;

			public int[] normal_faces;

			public int[] color_faces;
		}

		public class Kortez<T1, T2, T3>
		{
			public T1 Item1 { get; private set; }

			public T2 Item2 { get; private set; }

			public T3 Item3 { get; private set; }

			internal Kortez(T1 first, T2 second, T3 third)
				: base()
			{
			}
		}

		private bool SilentMode;

		private const string mRFImrtLibNiceName = "RF_CNative_andr";

		private const string mYear = "";

		private const string mConfigName = "";

		private uint mInnerFacesSubMeshIndex;

		private bool mExplode;

		private RFShatterMode mMode;

		private unsafe void* mShatterPtr;

		public RFShatter(RFShatterMode mode = RFShatterMode.classic, bool enable_fragmenting = false)
			: base()
		{
		}

		~RFShatter()
		{
		}

		public bool SetInputMesh(Transform transform, Mesh in_mesh)
		{
			return default(bool);
		}

		private void sl_element_mesh_par(int el, int sbc, Mesh origMesh, int InnerFacesSubMeshID, Transform transform, List<Dictionary<int, int>> OrigSubMeshIDs, Mesh[] out_mesh, Vector3[] pivots)
		{
		}

		public bool Compute(Transform transform, Mesh[] out_mesh, Vector3[] pivots, Mesh origMesh, int InnerFacesSubMeshID, List<Dictionary<int, int>> OrigSubMeshIDs)
		{
			return default(bool);
		}

		public void paral_for(object prms)
		{
		}

		public bool SimpleCompute(Transform transform, Mesh[] out_mesh, Vector3[] pivots, Mesh origMesh, int InnerFacesSubMeshID, List<Dictionary<int, int>> OrigSubMeshIDs, List<int> MarkedElements = default(List<int>), bool rebuildCells = true)
		{
			return default(bool);
		}

		public void InitClustering(bool enable = false)
		{
		}

		public void SetCenterParameter(Vector3 world_position, Transform transform, Vector3 normal)
		{
		}

		public void SetPoint3Parameter(int param_id, Vector3 p)
		{
		}

		public void GetMatrixParameter(int param_id, Matrix4x4 m)
		{
		}

		public void SetMatrixParameter(int param_id, Matrix4x4 m)
		{
		}

		public void SetBricksParams(Vector3[] points, Vector3[] normals, Transform transform)
		{
		}

		public void SetVoroCustomPoints(Vector3[] pts, Transform transform)
		{
		}

		public void SetPoints(FragmentParams param_id, Vector3[] pts)
		{
		}

		public void SetGeneralParameter<ValueType>(GeneralParams param_id, ValueType value)
		{
		}

		public void SetFragmentParameter<ValueType>(FragmentParams param_id, ValueType value)
		{
		}

		public void SetClusterParameter<ValueType>(ClusterParams param_id, ValueType value)
		{
		}

		public void DecomposeResultMesh(bool decompose = true)
		{
		}

		protected void CenterMesh(Transform transform, Mesh mesh, Vector3 out_center)
		{
		}

		protected unsafe void DetachMesh(safeMeshData out_mesh_data, safeMeshData in_mesh_data, int* selected_geom_verts, int* selected_geom_triangles, int* selected_uv_verts, int* selected_uv_triangles, int* selected_normal_verts, int* selected_normal_triangles, int* selected_color_verts, int* selected_color_triangles, int num_verts, int num_triangles, int num_uv_verts, int num_normal_verts, int num_color_verts, int* in_selected_faces, List<int> out_selected_faces)
		{
		}

		public void SilentModeEnable(bool enable)
		{
		}

		public void EditorMode(bool enable)
		{
		}

		protected void ConvertMesh(Transform transform, Mesh out_mesh, safeMeshData mesh_data, List<int> selected_faces, int el_ind, Mesh origMesh, List<Dictionary<int, int>> OrigSubMeshIDs, int InnerFacesSubMeshID)
		{
		}

		private unsafe static extern void* New(bool enable_fragmenting, int shatter_mode);

		private unsafe static extern void Delete(void* obj);

		private unsafe static extern void AddExtraUVWs(int numUVverts, float* UVverts);

		private unsafe static extern int SetInputMesh(void* shatter_ptr, int num_verts, float* verts, int num_faces, int* faces, int num_uv_verts, float* uv_verts, int* uv_faces, int num_normal_verts, float* normal_verts, int* normal_faces, int num_color_verts, float* color_verts, int* color_faces, int* selected_faces, bool simple_mode);

		private unsafe static extern int Sl_ElementData(void* shatter_ptr, int element_index, int* num_verts, int* num_non_selected_faces, int* num_selected_faces, int* numUVWsChannels);

		private unsafe static extern int Sl_ElementMesh(void* shatter_ptr, int element_index, float* verts, int* non_sel_triangles, int* sel_triangles, float* uvs, float* normals);

		private unsafe static extern void GetElementOrigInds(void* shatter_ptr, int el_index, int num_selected_faces, int num_non_selected_faces, int* non_selected_faces_inds, int type);

		private unsafe static extern void DisableSafeMode(void* shatter_ptr, bool disable);

		private unsafe static extern int Sl_Compute(void* shatter_ptr, int* num_elements, int numMarked, int* marked, bool rebuildCells);

		private unsafe static extern int Cl_Compute(void* shatter_ptr, int time, int* num_verts, int* num_faces, int* num_uv_verts, int* num_normal_verts, int* num_color_verts, int explode_flag, int* num_elements);

		private unsafe static extern int Cl_GetFinalMesh(void* shatter_ptr, int time, bool explode, float* verts, int* faces, float* uv_verts, int* uv_faces, float* normal_verts, int* normal_faces, float* color_verts, int* color_faces, int* selected_faces);

		private unsafe static extern bool Cl_GetExplodeElement(void* shatter_ptr, int time, int index, int* vertices, int* triangles, int* uv_verts, int* uv_triangles, int* normal_verts, int* normal_triangles, int* color_verts, int* color_triangles, int* num_verts, int* num_triangles, int* num_uv_verts, int* num_normal_verts, int* num_color_verts);

		private unsafe static extern void InitClusterParams(void* shatter_ptr, bool enable);

		private unsafe static extern void InvalidateClAll(void* shatter_ptr);

		private unsafe static extern void InvalidateClMaterial(void* shatter_ptr);

		private unsafe static extern void InvalidateClColor(void* shatter_ptr);

		private unsafe static extern void InvalidateClSTR(void* shatter_ptr);

		private unsafe static extern void InvalidateUVWMapping(void* shatter_ptr);

		private unsafe static extern bool RestoreVNormals(void* shatter_ptr);

		private unsafe static extern void InvalidateDmTotal(void* shatter_ptr);

		private unsafe static extern void InvalidateDmMaterial(void* shatter_ptr);

		private unsafe static extern void InvalidateDmSTR(void* shatter_ptr);

		private unsafe static extern void InvalidateFrVertices(void* shatter_ptr, bool invalidate_elements);

		private unsafe static extern void InvalidateFrSlice(void* shatter_ptr);

		private unsafe static extern void InvalidateFrMaterial(void* shatter_ptr);

		private unsafe static extern void InvalidateInput(void* shatter_ptr);

		private unsafe static extern void setCountPoint3(void* shatter_ptr, int param_id, int count_value);

		private unsafe static extern void setParamBool(void* shatter_ptr, int param_id, int time, bool value, int index);

		private unsafe static extern void getParamInteger(void* shatter_ptr, int param_id, int time, int* value, int index);

		private unsafe static extern void setParamInteger(void* shatter_ptr, int param_id, int time, int value, int index);

		private unsafe static extern void getParamFloat(void* shatter_ptr, int param_id, int time, float* value, int index);

		private unsafe static extern void setParamFloat(void* shatter_ptr, int param_id, int time, float value, int index);

		private unsafe static extern void setParamPoint3(void* shatter_ptr, int param_id, int time, float* value, int index);

		private unsafe static extern void getParamMatrix4x4(void* shatter_ptr, int param_id, int time, float** value, int index);

		private unsafe static extern void setParamMatrix4x4(void* shatter_ptr, int param_id, int time, float** value, int index);
	}
}
