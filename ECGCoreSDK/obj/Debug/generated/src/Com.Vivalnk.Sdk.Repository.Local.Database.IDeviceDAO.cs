using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']"
	[Register ("com/vivalnk/sdk/repository/local/database/IDeviceDAO", "", "Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker")]
	public partial interface IDeviceDAO : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalDevice...']]"
		[Register ("delete", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V", "GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("delete", "([Ljava/lang/String;)V", "GetDelete_arrayLjava_lang_String_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		void Delete (params string[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		void DeleteAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalDevice...']]"
		[Register ("insert", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V", "GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("query", "([Ljava/lang/String;)Ljava/util/List;", "GetQuery_arrayLjava_lang_String_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> Query (params string[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='queryAll' and count(parameter)=0]"
		[Register ("queryAll", "()Ljava/util/List;", "GetQueryAllHandler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> QueryAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/interface[@name='IDeviceDAO']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalDevice...']]"
		[Register ("update", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V", "GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler:Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAOInvoker, ECGCoreSDK")]
		void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0);

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/IDeviceDAO", DoNotGenerateAcw=true)]
	internal partial class IDeviceDAOInvoker : global::Java.Lang.Object, IDeviceDAO {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/IDeviceDAO", typeof (IDeviceDAOInvoker));

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

		public static IDeviceDAO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceDAO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.repository.local.database.IDeviceDAO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceDAOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler ()
		{
			if (cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == null)
				cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_);
			return cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		}

		static void n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		public unsafe void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0)
		{
			if (id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == IntPtr.Zero)
				id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNIEnv.GetMethodID (class_ref, "delete", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_delete_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_arrayLjava_lang_String_ == null)
				cb_delete_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLjava_lang_String_);
			return cb_delete_arrayLjava_lang_String_;
		}

		static void n_Delete_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_arrayLjava_lang_String_;
		public unsafe void Delete (params string[] p0)
		{
			if (id_delete_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_arrayLjava_lang_String_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler ()
		{
			if (cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == null)
				cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_);
			return cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		}

		static void n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		public unsafe void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0)
		{
			if (id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == IntPtr.Zero)
				id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNIEnv.GetMethodID (class_ref, "insert", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_query_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_arrayLjava_lang_String_Handler ()
		{
			if (cb_query_arrayLjava_lang_String_ == null)
				cb_query_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Query_arrayLjava_lang_String_);
			return cb_query_arrayLjava_lang_String_;
		}

		static IntPtr n_Query_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.ToLocalJniHandle (__this.Query (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_arrayLjava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> Query (params string[] p0)
		{
			if (id_query_arrayLjava_lang_String_ == IntPtr.Zero)
				id_query_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "([Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.ToLocalJniHandle (__this.QueryAll ());
		}
#pragma warning restore 0169

		IntPtr id_queryAll;
		public unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> QueryAll ()
		{
			if (id_queryAll == IntPtr.Zero)
				id_queryAll = JNIEnv.GetMethodID (class_ref, "queryAll", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryAll), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler ()
		{
			if (cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == null)
				cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_);
			return cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		}

		static void n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		public unsafe void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0)
		{
			if (id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == IntPtr.Zero)
				id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNIEnv.GetMethodID (class_ref, "update", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
