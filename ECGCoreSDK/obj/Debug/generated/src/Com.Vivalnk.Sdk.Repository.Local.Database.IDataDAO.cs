using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']"
	[Register ("com/vivalnk/sdk/repository/local/database/IDataDAO", "", "Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker")]
	public partial interface IDataDAO : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData...']]"
		[Register ("delete", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		void DeleteAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData...']]"
		[Register ("insert", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='query' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("query", "(Ljava/lang/String;J)Lcom/vivalnk/sdk/repository/local/database/VitalData;", "GetQuery_Ljava_lang_String_JHandler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData Query (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='query' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("query", "(Ljava/lang/String;JJ)Ljava/util/List;", "GetQuery_Ljava_lang_String_JJHandler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> Query (string p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='queryAll' and count(parameter)=0]"
		[Register ("queryAll", "()Ljava/util/List;", "GetQueryAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> QueryAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDataDAO']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData...']]"
		[Register ("update", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAOInvoker, ECGCoreSDK")]
		void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/IDataDAO", DoNotGenerateAcw=true)]
	internal partial class IDataDAOInvoker : global::Java.Lang.Object, IDataDAO {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/IDataDAO", typeof (IDataDAOInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IDataDAO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataDAO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.repository.local.database.IDataDAO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataDAOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler ()
		{
			if (cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == null)
				cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_);
			return cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		}

		static void n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		public unsafe void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0)
		{
			if (id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == IntPtr.Zero)
				id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNIEnv.GetMethodID (class_ref, "delete", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DeleteAll);
			return cb_deleteAll;
		}

		static void n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		IntPtr id_deleteAll;
		public unsafe void DeleteAll ()
		{
			if (id_deleteAll == IntPtr.Zero)
				id_deleteAll = JNIEnv.GetMethodID (class_ref, "deleteAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll);
		}

		static Delegate cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler ()
		{
			if (cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == null)
				cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_);
			return cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		}

		static void n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		public unsafe void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0)
		{
			if (id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == IntPtr.Zero)
				id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNIEnv.GetMethodID (class_ref, "insert", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_query_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_JHandler ()
		{
			if (cb_query_Ljava_lang_String_J == null)
				cb_query_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_Query_Ljava_lang_String_J);
			return cb_query_Ljava_lang_String_J;
		}

		static IntPtr n_Query_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_J;
		public unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData Query (string p0, long p1)
		{
			if (id_query_Ljava_lang_String_J == IntPtr.Zero)
				id_query_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;J)Lcom/vivalnk/sdk/repository/local/database/VitalData;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_query_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_JJHandler ()
		{
			if (cb_query_Ljava_lang_String_JJ == null)
				cb_query_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_L) n_Query_Ljava_lang_String_JJ);
			return cb_query_Ljava_lang_String_JJ;
		}

		static IntPtr n_Query_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.Query (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_JJ;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> Query (string p0, long p1, long p2)
		{
			if (id_query_Ljava_lang_String_JJ == IntPtr.Zero)
				id_query_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;JJ)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_queryAll;
#pragma warning disable 0169
		static Delegate GetQueryAllHandler ()
		{
			if (cb_queryAll == null)
				cb_queryAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryAll);
			return cb_queryAll;
		}

		static IntPtr n_QueryAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.QueryAll ());
		}
#pragma warning restore 0169

		IntPtr id_queryAll;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> QueryAll ()
		{
			if (id_queryAll == IntPtr.Zero)
				id_queryAll = JNIEnv.GetMethodID (class_ref, "queryAll", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryAll), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler ()
		{
			if (cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == null)
				cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_);
			return cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		}

		static void n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		public unsafe void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0)
		{
			if (id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == IntPtr.Zero)
				id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNIEnv.GetMethodID (class_ref, "update", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
